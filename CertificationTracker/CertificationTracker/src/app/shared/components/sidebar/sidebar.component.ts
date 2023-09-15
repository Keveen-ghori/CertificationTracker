import { Component, OnDestroy, OnInit } from '@angular/core';
import { ActivatedRoute, NavigationEnd, Router } from '@angular/router';
import { CookieService } from 'ngx-cookie-service';
import { ToastrService } from 'ngx-toastr';
import { UserService } from 'src/app/core/services/user.service';

@Component({
  selector: 'app-sidebar',
  templateUrl: './sidebar.component.html',
  styleUrls: ['./sidebar.component.css'],
})
export class SidebarComponent implements OnInit, OnDestroy {
  routerEvents: any;
  currentUrl: string = '/';
  userName: string = '';
  accessToken: string = this.cookieService.get('Token')!;
  constructor(
    private router: Router,
    private userService: UserService,
    private cookieService: CookieService
  ) {
    this.routerEvents = this.router.events.subscribe((event) => {
      if (event instanceof NavigationEnd) {
        this.currentUrl = event.url;
      }
    });
  }

  ngOnInit() {
    if (this.accessToken) {
      const tokenParts = this.accessToken.split('.');
      if (tokenParts.length === 3) {
        const payload = tokenParts[1];
        try {
          const decodedPayload = JSON.parse(atob(payload));
          this.userName = decodedPayload.UserName.toString();
        } catch (error) {
          console.error('Error decoding JWT payload:', error);
        }
      }
    }
  }

  Logout = (userName: string) => {
    this.userService.Logout(userName);
  };

  ngOnDestroy(): void {
    this.routerEvents.unsubscribe();
  }
}
