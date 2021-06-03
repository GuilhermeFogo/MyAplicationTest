import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormUserComponent } from './form-user.component';
import { MatDialogModule } from '@angular/material/dialog';
import { MatButtonModule } from '@angular/material/button';
import { ReactiveFormsModule } from '@angular/forms';
import {MatCheckboxModule} from '@angular/material/checkbox';
import { MatInputModule } from '@angular/material/input';
import { SelectRoleModule } from '../select-role/select-role.module';



@NgModule({
  declarations: [FormUserComponent],
  imports: [
    CommonModule,
    MatDialogModule,
    MatButtonModule,
    MatInputModule,
    MatCheckboxModule,
    ReactiveFormsModule,
    SelectRoleModule
  ], exports:[FormUserComponent],
  entryComponents:[FormUserComponent]
})
export class FormUserModule { }
