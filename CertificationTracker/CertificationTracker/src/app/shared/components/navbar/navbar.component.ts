import { Component, OnDestroy, OnInit } from '@angular/core';
import { NavigationEnd, Router } from '@angular/router';

@Component({
  selector: 'app-navbar',
  templateUrl: './navbar.component.html',
  styleUrls: ['./navbar.component.css'],
})
export class NavbarComponent implements OnInit, OnDestroy {
  routerEvents: any;
  currentUrl: string = '';
  currentTab: string = 'Applications';
  date: Date = new Date();
  constructor(private router: Router) {
    this.routerEvents = this.router.events.subscribe((event) => {
      if (event instanceof NavigationEnd) {
        this.currentUrl = event.url;
        if (this.currentUrl == '/') {
          this.currentTab = 'Applications';
        } else if (this.currentUrl == '/area') {
          this.currentTab = 'Course Area';
        }
      }
    });

    setInterval(() => {
      this.date = new Date();
    }, 1000);
  }

  ngOnInit() {}
  ngOnDestroy(): void {
    this.routerEvents.unsubscribe();
  }
}
