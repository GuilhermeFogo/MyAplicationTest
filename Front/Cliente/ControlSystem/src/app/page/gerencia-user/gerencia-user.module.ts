import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { GerenciaUserComponent } from './gerencia-user.component';
import {MatDialogModule} from '@angular/material/dialog';
import { MatButtonModule } from '@angular/material/button';
import {MatTableModule} from '@angular/material/table';
import { GerenciaUserRoutingModule } from './gerencia-user-routing-module';
import { FormUserModule } from 'src/app/module/users/form-user/form-user.module';



@NgModule({
  declarations: [GerenciaUserComponent],
  imports: [
    CommonModule,
    MatDialogModule,
    MatButtonModule,
    MatTableModule,
    GerenciaUserRoutingModule,
    FormUserModule
  ], exports:[GerenciaUserComponent]
})
export class GerenciaUserModule { }
