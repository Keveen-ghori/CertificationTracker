import { Component, OnDestroy, OnInit } from '@angular/core';

import {
  FormGroup,
  FormControl,
  Validators,
  FormBuilder,
  NgForm,
} from '@angular/forms';
import { LoginModel } from '../../core/interfaces/login.interface';
import { ActivatedRoute, Router } from '@angular/router';
import { UserService } from '../../core/services/user.service';
import { ApiResponse } from 'src/app/core/interfaces/apiResponse.interface';
import { CookieService } from 'ngx-cookie-service';
import { getCookieValue } from 'src/app/core/Constants/cookieValue';
import { Subscription, take } from 'rxjs';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-auth',
  templateUrl: './auth.component.html',
  styleUrls: ['./auth.component.css'],
})
export class AuthComponent implements OnInit, OnDestroy {
  invalidLogin!: boolean;
  credentials!: LoginModel;
  loginForm!: FormGroup;
  apiResponse!: ApiResponse;
  validationErrors!: Array<{ messageType: string; message: string }>;
  accessToken: string | null = localStorage.getItem('access_token');
  private subscription: Subscription | null = null;

  constructor(
    public fb: FormBuilder,
    private router: Router,
    private userService: UserService,
    private route: ActivatedRoute,
    private cookieService: CookieService,
    private toastr: ToastrService
  ) {}

  ngOnInit() {
    this.loginForm = this.fb.group({
      userName: ['', Validators.required],
      password: ['', [Validators.required]],
    });

    // this.subscription = this.userService.user$.subscribe((x) => {
    //   if (this.route.snapshot.url[0].path === 'login') {
    //     const accessToken = localStorage.getItem('access_token');
    //     const refreshToken = localStorage.getItem('refresh_token');
    //     if (x && accessToken && refreshToken) {
    //       const returnUrl = this.route.snapshot.queryParams['returnUrl'] || '';
    //       this.router.navigate([returnUrl]);
    //     }
    //   }
    // });

    this.subscription = this.userService.user$.subscribe((x) => {
      if (this.route.snapshot.url[0].path === 'login') {
        const accessToken = getCookieValue(this.cookieService, 'Token');
        const refreshToken = getCookieValue(this.cookieService, 'RefreshToken');
        if (x && accessToken && refreshToken) {
          const returnUrl = this.route.snapshot.queryParams['returnUrl'] || '';
          this.router.navigate([returnUrl]);
        }
      } // optional touch-up: if a tab shows login page, then refresh the page to reduce duplicate login
    });
  }

  get registerFormControl() {
    return this.loginForm.controls;
  }

  login = () => {
    const returnUrl = this.route.snapshot.queryParams['returnUrl'] || '';
    this.credentials = this.loginForm.value;

    this.userService.Login(this.credentials).subscribe(
      (response: ApiResponse) => {
        if (response.success == true) {
          this.router.navigate([returnUrl]);
          this.toastr.success('You have successfully logged in.');
        } else {
          this.validationErrors = response.messages || [];
        }
      },

      (err: any) => {}
    );
  };

  ngOnDestroy() {
    this.subscription?.unsubscribe();
  }
}
