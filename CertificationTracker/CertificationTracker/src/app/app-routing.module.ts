import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AuthComponent } from './features/auth/auth.component';
import { AppComponent } from './app.component';
import { DashboardComponent } from './features/dashboard/dashboard.component';
import { CourseAreaComponent } from './features/coursearea/components/coursearea.component';
import { AuthGuard } from './core/gaurds/auth.guard';
import { CourseConfigurationComponent } from './features/configurecourse/components/courseconfiguration.component';

const routes: Routes = [
  {
    path: '',
    component: DashboardComponent,
    pathMatch: 'full',
    canActivate: [AuthGuard],
  },
  { path: 'login', component: AuthComponent },
  { path: 'area', component: CourseAreaComponent, canActivate: [AuthGuard] },
  {
    path: 'courseconfiguration',
    component: CourseConfigurationComponent,
    canActivate: [AuthGuard],
  },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
})
export class AppRoutingModule {}
