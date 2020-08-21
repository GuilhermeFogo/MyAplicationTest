import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormLoginComponent } from './form-login.component';
import {MatButtonModule} from '@angular/material/button';
import { ReactiveFormsModule } from '@angular/forms';
import {MatInputModule} from '@angular/material/input';
import { HttpClientModule } from '@angular/common/http';


@NgModule({
  declarations: [FormLoginComponent],
  imports: [
    CommonModule,
    MatButtonModule,
    ReactiveFormsModule,
    MatInputModule,
    HttpClientModule
  ], exports: [FormLoginComponent]
})
export class FormLoginModule { }
