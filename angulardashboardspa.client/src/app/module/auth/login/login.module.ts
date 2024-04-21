import { NgModule } from '@angular/core';
import { HeaderComponent } from '../header/header.component';
import { CommonModule } from '@angular/common';
import { LoginComponent } from './login.component';
import { CardModule } from 'primeng/card';
import { ToolbarModule } from 'primeng/toolbar';
import { InputSwitchModule } from 'primeng/inputswitch';
import { FormsModule } from '@angular/forms';
import { InputTextModule } from 'primeng/inputtext';
import { ButtonModule } from 'primeng/button';
import { PasswordModule } from 'primeng/password';

@NgModule({
  declarations: [LoginComponent, HeaderComponent],
  imports: [
    CommonModule,
    CardModule,
    ToolbarModule,
    InputSwitchModule,
    FormsModule,
    InputTextModule,
    ButtonModule,
    PasswordModule,
  ],
})
export class LoginModule {}
