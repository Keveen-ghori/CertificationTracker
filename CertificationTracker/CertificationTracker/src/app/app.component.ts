import { Component, OnInit } from '@angular/core';
import { NavigationEnd, Router } from '@angular/router';
import { CookieService } from 'ngx-cookie-service';
import { filter } from 'rxjs/operators';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css'],
})
export class AppComponent implements OnInit {
  title = 'Certification Tracker';

  blankUrl: boolean = false;
  currentUrl: string | undefined;
  checkoutUrls = ['/login'];

  constructor(private router: Router, private cookieService: CookieService) {
    router.events
      .pipe(filter((event: any) => event instanceof NavigationEnd))
      .subscribe((e: NavigationEnd) => {
        this.currentUrl = e.url;
      });
  }

  ngOnInit(): void {
    if (this.cookieService.get('RefreshToken') == '') {
      this.router.navigate(['login']);
    }
  }

  isCheckoutRoute() {
    return this.currentUrl && this.checkoutUrls.includes(this.currentUrl);
  }
}
