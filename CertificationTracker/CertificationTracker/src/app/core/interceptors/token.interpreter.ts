import { Injectable } from '@angular/core';
import {
  HttpRequest,
  HttpHandler,
  HttpEvent,
  HttpInterceptor,
  HttpHeaders,
} from '@angular/common/http';
import { Observable, finalize } from 'rxjs';
import { environment } from 'src/environments/environment.development';
import { UserService } from '../services/user.service';
import { CookieService } from 'ngx-cookie-service';
import { LoaderService } from '../services/loader.service';

@Injectable()
export class TokenInterceptor implements HttpInterceptor {
  constructor(
    private authService: UserService,
    private cookieService: CookieService,
    private loader: LoaderService
  ) {}

  intercept(
    request: HttpRequest<unknown>,
    next: HttpHandler
  ): Observable<HttpEvent<unknown>> {
    // this.loader.showLoader();
    const accessToken = this.cookieService.get('Token');
    const isApiUrl = request.url.startsWith(environment.TRACKER_API);
    if (accessToken && isApiUrl) {
      request = request.clone({
        setHeaders: {
          Authorization: `Bearer ${accessToken}`,
        },
      });
    }
    return next.handle(request);
    // .pipe(
    //   finalize(() =>
    //     setTimeout(() => {
    //       this.loader.hideLoader();
    //     }, 1000)
    //   )
    // );
  }
}
