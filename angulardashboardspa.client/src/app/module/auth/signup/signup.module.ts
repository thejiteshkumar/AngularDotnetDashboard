import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { SignupComponent } from './signup.component';
import { CardModule } from 'primeng/card';
import { ToolbarModule } from 'primeng/toolbar';
import { FormsModule } from '@angular/forms';
import { InputTextModule } from 'primeng/inputtext';
import { ButtonModule } from 'primeng/button';
import { PasswordModule } from 'primeng/password';
import { HeaderModule } from '../header/header.module';
import { RouterModule } from '@angular/router';


@NgModule({
  declarations: [SignupComponent],
  imports: [
    CommonModule,
    CardModule,
    ToolbarModule,
    FormsModule,
    InputTextModule,
    ButtonModule,
    PasswordModule,
    HeaderModule,
    RouterModule
  ],
})
export class SignupModule {}
