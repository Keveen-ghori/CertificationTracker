import {
  HttpClient,
  HttpErrorResponse,
  HttpHeaders,
  HttpResponse,
} from '@angular/common/http';
import { Injectable, OnDestroy } from '@angular/core';
import { LoginModel } from '../interfaces/login.interface';
import { environment } from 'src/environments/environment.development';
import { catchError, delay, finalize, map, tap } from 'rxjs/operators';
import {
  BehaviorSubject,
  Observable,
  Subscription,
  of,
  throwError,
} from 'rxjs';
import { ApiResponse } from '../interfaces/apiResponse.interface';
import { ApplicationUser } from '../interfaces/applicationUser.interface';
import { Router } from '@angular/router';
import { CookieService } from 'ngx-cookie-service';
import { NotificationService } from './notification.service';

@Injectable({
  providedIn: 'root',
})
export class UserService implements OnDestroy {
  private timer: Subscription | null = null;
  private _user = new BehaviorSubject<ApplicationUser | null>(null);
  user$ = this._user.asObservable();

  constructor(
    private httpClient: HttpClient,
    private router: Router,
    private cookieService: CookieService,
    private notificationService: NotificationService
  ) {
    window.addEventListener('storage', this.storageEventListener.bind(this));
  }

  private storageEventListener(event: StorageEvent) {
    if (event.storageArea === localStorage) {
      if (event.key === 'logout-event') {
        this.stopTokenTimer();
        this._user.next(null);
      }
      if (event.key === 'login-event') {
        this.stopTokenTimer();
        this.httpClient
          .get<ApiResponse>(`${environment.TRACKER_API}/Account/User`, {
            withCredentials: true,
          })
          .subscribe((x) => {
            this._user.next({
              refreshToken: x.content.refreshToken,
              accessToken: x.content.accessToken,
            });
          });
      }
    }
  }

  Login(user: LoginModel): Observable<ApiResponse> {
    return this.httpClient
      .post<ApiResponse>(`${environment.TRACKER_API}/Account/Login`, user, {
        withCredentials: true,
      })
      .pipe(
        map((x: ApiResponse) => {
          if (x.success) {
            this._user.next({
              refreshToken: x.content.refreshToken ?? '',
              accessToken: x.content.accessToken ?? '',
            });
          }
          if (x.success && x.messages?.length == 0) {
            localStorage.setItem('login-event', 'login' + Math.random());
            this.startTokenTimer();
          }
          return x;
        })
      );
  }

  Logout(userName: string) {
    this.httpClient
      .post(
        `${environment.TRACKER_API}/Account/Logout?UserName=${userName}`,
        {}
      )
      .pipe(
        finalize(() => {
          this.DeleteCookie();
          this._user.next(null);
          this.stopTokenTimer();
          this.router.navigate(['login']);
          localStorage.removeItem('logout-event');
          this.notificationService.showSuccess(
            'You successfully logged out.',
            'Logout'
          );
        })
      )
      .subscribe();
  }

  refreshToken(): Observable<ApiResponse | null> {
    const refreshToken = this.cookieService.get('RefreshToken');
    const accessToken = this.cookieService.get('Token');
    var UserName = '';

    if (accessToken) {
      const tokenParts = accessToken.split('.');
      if (tokenParts.length === 3) {
        const payload = tokenParts[1];
        try {
          const decodedPayload = JSON.parse(atob(payload));
          UserName = decodedPayload.UserName.toString();
        } catch (error) {
          console.error('Error decoding JWT payload:', error);
        }
      }
    }

    if (!refreshToken && !accessToken) {
      this.DeleteCookie();
      return of(null);
    }
    return this.httpClient
      .post<ApiResponse>(
        `${environment.TRACKER_API}/Account/RefreshToken`,
        {
          accessToken,
          refreshToken,
        },
        { withCredentials: true }
      )
      .pipe(
        map((x: ApiResponse) => {
          if (x.messages?.length == 0) {
            this._user.next({
              refreshToken: x.content.refreshToken,
              accessToken: x.content.accessToken,
            });
            if (x.success) {
              localStorage.setItem('login-event', 'login' + Math.random());
              this.startTokenTimer();
            }
            return x;
          } else {
            this.Logout(UserName);
            this.notificationService.showError(
              x.messages?.[0]?.message ||
                'Default error message' + 'Please login to the system.',
              'Token expired'
            );
            return x;
          }
        })
      );
  }

  DeleteCookie() {
    this.cookieService.deleteAll();
  }
  ngOnDestroy(): void {
    window.removeEventListener('storage', this.storageEventListener.bind(this));
  }

  private getTokenRemainingTime() {
    const accessToken = this.cookieService.get('Token');
    if (!accessToken) {
      return 0;
    }
    const jwtToken = JSON.parse(atob(accessToken.split('.')[1]));
    const expires = new Date(jwtToken.exp * 1000);
    return expires.getTime() - Date.now();
  }

  private startTokenTimer() {
    const timeout = this.getTokenRemainingTime();
    this.timer = of(true)
      .pipe(
        delay(timeout),
        tap({
          next: () => this.refreshToken().subscribe(),
        })
      )
      .subscribe();
  }

  private stopTokenTimer() {
    this.timer?.unsubscribe();
  }

  //#region Configuration Settings
  ConfigurationSettings(): Observable<ApiResponse> {
    return this.httpClient
      .get(`${environment.TRACKER_API}/Account/Configuration`)
      .pipe(map((response: any) => response as ApiResponse));
  }
  //#endregion
}
