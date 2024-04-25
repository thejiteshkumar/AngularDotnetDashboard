import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { LoginComponent } from './login.component';
import { CardModule } from 'primeng/card';
import { ToolbarModule } from 'primeng/toolbar';
import { InputSwitchModule } from 'primeng/inputswitch';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { InputTextModule } from 'primeng/inputtext';
import { ButtonModule } from 'primeng/button';
import { PasswordModule } from 'primeng/password';
import { RouterModule } from '@angular/router';
import { HeaderModule } from '../header/header.module';

@NgModule({
  declarations: [LoginComponent],
  imports: [
    HeaderModule,
    CommonModule,
    CardModule,
    RouterModule,
    ToolbarModule,
    InputSwitchModule,
    FormsModule,
    InputTextModule,
    ButtonModule,
    PasswordModule,
    ReactiveFormsModule
  ],
})
export class LoginModule {}
