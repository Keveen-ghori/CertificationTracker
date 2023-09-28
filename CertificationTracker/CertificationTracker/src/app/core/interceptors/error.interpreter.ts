import { Injectable } from '@angular/core';
import {
  HttpEvent,
  HttpInterceptor,
  HttpHandler,
  HttpRequest,
  HttpErrorResponse,
} from '@angular/common/http';
import { Observable, throwError } from 'rxjs';
import { catchError } from 'rxjs/operators';
import { UserService } from '../services/user.service';
import { NotificationService } from '../services/notification.service';

@Injectable({ providedIn: 'root' })
export class ErrorInterceptor implements HttpInterceptor {
  // intercept(
  //   req: HttpRequest<any>,
  //   next: HttpHandler
  // ): Observable<HttpEvent<any>> {
  //   return next
  //     .handle(req)
  //     .pipe(catchError((err: HttpErrorResponse) => throwError(err)));
  // }

  constructor(
    private authenticationService: UserService,
    private notificationService: NotificationService
  ) {}
  intercept(
    request: HttpRequest<any>,
    next: HttpHandler
  ): Observable<HttpEvent<any>> {
    return next.handle(request).pipe(
      catchError((err) => {
        if (
          [401, 403].includes(err.status) &&
          this.authenticationService.user$
        ) {
          this.notificationService.showError(err.message, err.status);
          // auto logout if 401 or 403 response returned from api
        }

        if (err.status === 0) {
          this.notificationService.showError(
            'Problems while connecting to the server',
            'Server Unaccessible.'
          );
        }

        const error = (err && err.error && err.error.message) || err.statusText;
        console.error(err);
        return throwError(error);
      })
    );
  }
}
