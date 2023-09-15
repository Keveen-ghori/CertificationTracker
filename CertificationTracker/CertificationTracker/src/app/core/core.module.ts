import { APP_INITIALIZER, NgModule, Optional, SkipSelf } from '@angular/core';

import {
  FormControl,
  FormGroup,
  FormsModule,
  ReactiveFormsModule,
  Validators,
} from '@angular/forms';

import { takeUntil } from 'rxjs/operators';

import { Subject } from 'rxjs';
import { HTTP_INTERCEPTORS, HttpClientModule } from '@angular/common/http';
import { CommonModule } from '@angular/common';
import { UserService } from './services/user.service';
import { appInitializer } from './services/appInitializer';
import { TokenInterceptor } from './interceptors/token.interpreter';
import { UnauthorizedInterceptor } from './interceptors/unauthorized.Interceptor';
import { ErrorInterceptor } from './interceptors/error.interpreter';

@NgModule({
  imports: [HttpClientModule],
  exports: [],
  declarations: [],
  providers: [
    {
      provide: APP_INITIALIZER,
      useFactory: appInitializer,
      multi: true,
      deps: [UserService],
    },
    { provide: HTTP_INTERCEPTORS, useClass: TokenInterceptor, multi: true },
    { provide: HTTP_INTERCEPTORS, useClass: ErrorInterceptor, multi: true },
    {
      provide: HTTP_INTERCEPTORS,
      useClass: UnauthorizedInterceptor,
      multi: true,
    },
  ],
})
export class CoreModule {
  constructor(@Optional() @SkipSelf() core: CoreModule) {
    if (core) {
      throw new Error('Core Module can only be imported to AppModule.');
    }
  }
}
