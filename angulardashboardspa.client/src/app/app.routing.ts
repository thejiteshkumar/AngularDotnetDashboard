import { Routes } from '@angular/router';
import { LoginComponent } from './module/auth/login/login.component';
import { SignupComponent } from './module/auth/signup/signup.component';
import { HomeComponent } from './module/dashboard/home/home.component';

export const routes: Routes = [
  { path: 'home', component: HomeComponent },
  { path: '', component: LoginComponent },
  { path: 'sign-up', component: SignupComponent },
];
