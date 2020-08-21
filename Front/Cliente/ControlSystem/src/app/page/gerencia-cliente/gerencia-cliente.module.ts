import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { GerenciaClienteRoutingModule } from './gerencia-cliente-routing.module';
import { GerenciaClienteComponent } from './gerencia-cliente.component';
import { FormClienteModule } from 'src/app/module/cliente/component/form-cliente/form-cliente.module';
import { MatDialogModule } from '@angular/material/dialog';


@NgModule({
  declarations: [GerenciaClienteComponent],
  imports: [
    CommonModule,
    GerenciaClienteRoutingModule,
    FormClienteModule,
    MatDialogModule
  ], exports:[GerenciaClienteComponent]
})
export class GerenciaClienteModule { }
