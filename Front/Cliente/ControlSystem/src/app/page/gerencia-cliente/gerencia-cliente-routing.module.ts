import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { GerenciaClienteComponent } from './gerencia-cliente.component';


const routes: Routes = [
  {path:'', component: GerenciaClienteComponent}
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class GerenciaClienteRoutingModule { }
