import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { AuthService } from '../../../services/auth/auth.service';
import { LoginData } from '../../../models/login-data';
import { Router, RouterLink } from '@angular/router';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrl: './login.component.css',
})
export class LoginComponent implements OnInit{
  constructor(private authService: AuthService, private router: Router) {}
  ngOnInit(): void {
  }

  loading: boolean = false;

  loginForm = new FormGroup({
    email: new FormControl('', [Validators.required, Validators.email]),
    password: new FormControl('', [
      Validators.required,
      Validators.minLength(6),
    ]),
  });

  signIn() {
    if (this.loginForm.valid) {
      //this.loading = true;

      console.log(this.loginForm);

      const loginData: LoginData = {
        emailOrUserName: this.loginForm.value.email ?? '',
        password: this.loginForm.value.password ?? '',
      };

      this.authService.login(loginData).subscribe((response) => {
        this.loading = false;
        this.router.navigate(['/home']);
      });
    } else {
      // Handle form validation errors
      // Mark all fields as touched to display validation messages
      this.loginForm.markAllAsTouched();
    }
  }
}
