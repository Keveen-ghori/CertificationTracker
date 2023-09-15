import { CommonModule } from '@angular/common';
import { HTTP_INTERCEPTORS, HttpClientModule } from '@angular/common/http';
import { APP_INITIALIZER, NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';
import { DashboardComponent } from './dashboard/dashboard.component';
import { CourseAreaComponent } from './coursearea/components/coursearea.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { AuthComponent } from './auth/auth.component';
import { AreaHeaderComponent } from './coursearea/containers/header/header.containers';
import { CourseAreaContentComponent } from './coursearea/containers/contents/content.coursearea.component';
import { POSTCourseAreaService } from '../core/services/postcoursearea.service';
import { UserService } from '../core/services/user.service';
import { appInitializer } from '../core/services/appInitializer';
import { TokenInterceptor } from '../core/interceptors/token.interpreter';
import { ErrorInterceptor } from '../core/interceptors/error.interpreter';
import { UnauthorizedInterceptor } from '../core/interceptors/unauthorized.Interceptor';
import { AuthGuard } from '../core/gaurds/auth.guard';
import { MathFloorPipe } from '../core/pipe/mathFloorPipe';
import { MathCeilPipe } from '../core/pipe/mathCeilPipe';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { RequirementsPanelContainer } from './coursearea/containers/requirementspanel/requirementspanel.container';
import { MatButtonModule } from '@angular/material/button';

import { MatIconModule } from '@angular/material/icon';

import { MatFormFieldModule } from '@angular/material/form-field';

import { MatInputModule } from '@angular/material/input';

import { MatDialogModule } from '@angular/material/dialog';

import { MatTabsModule } from '@angular/material/tabs';

import { MatSort, MatSortModule } from '@angular/material/sort';

import { MatPaginator, MatPaginatorModule } from '@angular/material/paginator';
import { MatTableModule } from '@angular/material/table';
import { POSTAreaDetailDialog } from './coursearea/containers/POSTAreaDetailDialog/postareadetail.dialog';
import { ToastrModule } from 'ngx-toastr';
import { MatSlideToggleModule } from '@angular/material/slide-toggle';
import { MatProgressSpinnerModule } from '@angular/material/progress-spinner';
import { CourseConfigurationComponent } from './configurecourse/components/courseconfiguration.component';

const materialModules = [
  MatButtonModule,
  MatIconModule,
  MatFormFieldModule,
  MatInputModule,
  MatDialogModule,
  MatTabsModule,
  MatTabsModule,
  MatSortModule,
  MatPaginatorModule,
  MatTableModule,
  MatProgressSpinnerModule,
  MatSlideToggleModule,
];

@NgModule({
  imports: [
    CommonModule,
    RouterModule,
    HttpClientModule,
    ReactiveFormsModule,
    FormsModule,
    BrowserAnimationsModule,
    materialModules,
    ToastrModule.forRoot(),
  ],
  exports: [
    RouterModule,
    HttpClientModule,
    DashboardComponent,
    CourseAreaComponent,
    AreaHeaderComponent,
    CourseAreaContentComponent,
    RequirementsPanelContainer,
    POSTAreaDetailDialog,
    CourseConfigurationComponent,
  ],
  declarations: [
    DashboardComponent,
    CourseAreaComponent,
    AuthComponent,
    AreaHeaderComponent,
    CourseAreaContentComponent,
    MathFloorPipe,
    MathCeilPipe,
    RequirementsPanelContainer,
    POSTAreaDetailDialog,
    CourseConfigurationComponent,
  ],
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
    AuthGuard,
    POSTCourseAreaService,
  ],
})
export class FeatureModule {}
