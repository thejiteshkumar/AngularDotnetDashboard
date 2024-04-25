import { Component } from '@angular/core';
import {
  trigger,
  state,
  style,
  animate,
  transition,
} from '@angular/animations';

@Component({
  selector: 'app-signup',
  templateUrl: './signup.component.html',
  styleUrl: './signup.component.css',
  animations: [
    trigger('slideAndFade', [
      transition(':enter', [
        style({ transform: 'translateX(-100%)', opacity: 0 }),
        animate(
          '500ms ease-out',
          style({ transform: 'translateX(0)', opacity: 1 })
        ),
      ]),
      transition(':leave', [
        animate(
          '500ms ease-in',
          style({ transform: 'translateX(-100%)', opacity: 0 })
        ),
      ]),
    ]),
  ],
})
export class SignupComponent {
  chooseUsername = false;
  loading: boolean = false;
  password: string = '';

  signUp() {
    this.loading = true;
    this.chooseUsername = !this.chooseUsername;

    setTimeout(() => {
      this.loading = false;
    }, 2000);
  }

  createUsername() {
    this.loading = true;

    setTimeout(() => {
      this.loading = false;
    }, 1000);
  }
}
