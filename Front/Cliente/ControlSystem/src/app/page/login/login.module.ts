import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { LoginRoutingModule } from './login-routing.module';
import { LoginComponent } from './login.component';
import { FormLoginModule } from 'src/app/module/users/form-login/form-login.module';


@NgModule({
  declarations: [LoginComponent],
  imports: [
    CommonModule,
    LoginRoutingModule,
    FormLoginModule
  ], exports: [LoginComponent]
})
export class LoginModule { }
