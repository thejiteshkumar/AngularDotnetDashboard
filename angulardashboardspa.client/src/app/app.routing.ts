import { Routes } from '@angular/router';
import { LoginComponent } from './module/auth/login/login.component';
import { SignupComponent } from './module/auth/signup/signup.component';

export const routes: Routes = [
  { path: '', component: LoginComponent },
  { path: 'sign-in', component: LoginComponent },
  { path: 'sign-up', component: SignupComponent },
];
