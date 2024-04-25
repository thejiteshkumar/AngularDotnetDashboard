import { Component } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrl: './login.component.css',
})
export class LoginComponent {
  loading: boolean = false;

  loginForm = new FormGroup({
    email: new FormControl('', [Validators.required, Validators.email]),
    password: new FormControl('', [Validators.required , Validators.minLength(6)]),
  });

  signIn() {
    if (this.loginForm.valid) {
      this.loading = true;

      console.log(this.loginForm);

      setTimeout(() => {
        this.loading = false;
      }, 2000);
    } else {
      // Handle form validation errors
      // Mark all fields as touched to display validation messages
      this.loginForm.markAllAsTouched();
    }
  }
}
