import { CommonModule } from '@angular/common';
import { HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';
import { FooterComponent } from './components/footer/footer.component';
import { NavbarComponent } from './components/navbar/navbar.component';
import { SidebarComponent } from './components/sidebar/sidebar.component';

@NgModule({
  imports: [CommonModule, RouterModule, HttpClientModule],
  exports: [
    CommonModule,
    RouterModule,
    HttpClientModule,
    FooterComponent,
    NavbarComponent,
    SidebarComponent,
  ],
  declarations: [FooterComponent, NavbarComponent, SidebarComponent],
})
export class SharedModule {}
