import { Component } from '@angular/core';

@Component({
  selector: 'app-signup',
  templateUrl: './signup.component.html',
  styleUrl: './signup.component.css',
})
export class SignupComponent {
  chooseUsername = false;
  loading: boolean = false;
  password: string = '';
  
  signUp() {
    this.loading = true;

    setTimeout(() => {
      this.loading = false;
    }, 2000);
  }

  createUsername() {
     this.loading = true;

     setTimeout(() => {
       this.loading = false;
     }, 1000);
    
    this.chooseUsername = !this.chooseUsername;
  }
}
