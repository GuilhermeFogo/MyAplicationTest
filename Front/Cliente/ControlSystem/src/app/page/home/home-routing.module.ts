import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { HomeComponent } from './home.component';
import { GerenciaUserComponent } from '../gerencia-user/gerencia-user.component';
import { GerenciaClienteComponent } from '../gerencia-cliente/gerencia-cliente.component';

const routes: Routes = [
  // {path:'', component: HomeComponent},
  // {path:'gerenciaUser', loadChildren:()=> import('../gerencia-user/gerencia-user.module').then(m=> m.GerenciaUserModule)},
  // {path:'gerenciaCliente', loadChildren:()=> import('../gerencia-cliente/gerencia-cliente.module').then(m=> m.GerenciaClienteModule)},
];


@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class HomeRoutingModule { }
