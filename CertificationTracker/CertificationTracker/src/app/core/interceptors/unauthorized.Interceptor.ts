import { Injectable } from '@angular/core';
import {
  HttpRequest,
  HttpHandler,
  HttpEvent,
  HttpInterceptor,
  HttpErrorResponse,
} from '@angular/common/http';
import { Observable, Subject, throwError } from 'rxjs';
import { catchError } from 'rxjs/operators';
import { environment } from 'src/environments/environment.development';
import { Router } from '@angular/router';
import { UserService } from '../services/user.service';
import { CookieService } from 'ngx-cookie-service';
import { NotificationService } from '../services/notification.service';

@Injectable()
export class UnauthorizedInterceptor implements HttpInterceptor {
  constructor(
    private userService: UserService,
    private router: Router,
    private cookieService: CookieService,
    private toaster: NotificationService
  ) {}

  intercept(
    request: HttpRequest<unknown>,
    next: HttpHandler
  ): Observable<HttpEvent<unknown>> {
    return next.handle(request).pipe(
      catchError((err: HttpErrorResponse) => {
        debugger;
        if (err.status === 401) {
          this.router.navigate(['/'], {
            queryParams: { returnUrl: this.router.routerState.snapshot.url },
          });
          this.toaster.showError(
            'You are not authorize to access this page.',
            'Unauthorize Access.'
          );
        }
        if (err.status == 429) {
          this.toaster.showError('To Many Requests', '429');
        }

        if (!environment.production) {
          console.error(err);
        }

        if (err.status == 0) {
          const tokenParts = this.cookieService.get('Token').split('.');
          if (tokenParts.length === 3) {
            const payload = tokenParts[1];
            try {
              const decodedPayload = JSON.parse(atob(payload));
              this.userService.Logout(decodedPayload.UserName.toString());
              this.toaster.showError(
                'Problems while connecting to the server',
                'Server Unaccessible.'
              );
            } catch (error) {
              console.error('Error decoding JWT payload:', error);
              this.toaster.showError('error', 'Error decoding JWT payload.');
            }
          }
        }
        const error = (err && err.error && err.message) || err.statusText;
        return throwError(error);
      })
    );
  }
}
