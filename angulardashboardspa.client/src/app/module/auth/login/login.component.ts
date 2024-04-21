import { Component } from '@angular/core';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrl: './login.component.css',
})
export class LoginComponent {
  loading: boolean = false;
  password: string = "";
  signIn() {
    this.loading = true;

    setTimeout(() => {
      this.loading = false;
    }, 2000);
  }
}
