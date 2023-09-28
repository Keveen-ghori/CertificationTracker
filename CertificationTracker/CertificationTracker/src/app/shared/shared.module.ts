import { CommonModule } from '@angular/common';
import { HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';
import { FooterComponent } from './components/footer/footer.component';
import { NavbarComponent } from './components/navbar/navbar.component';
import { SidebarComponent } from './components/sidebar/sidebar.component';
import { MatProgressSpinnerModule } from '@angular/material/progress-spinner';
import { SpinnerComponent } from './components/spinner/spinner.component';

@NgModule({
  imports: [
    CommonModule,
    RouterModule,
    HttpClientModule,
    MatProgressSpinnerModule,
  ],
  exports: [
    CommonModule,
    RouterModule,
    HttpClientModule,
    FooterComponent,
    NavbarComponent,
    SidebarComponent,
    SpinnerComponent,
  ],
  declarations: [
    FooterComponent,
    NavbarComponent,
    SidebarComponent,
    SpinnerComponent,
  ],
})
export class SharedModule {}
