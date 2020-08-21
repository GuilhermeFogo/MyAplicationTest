import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { LoginComponent } from './page/login/login.component';
import { RouteGuard } from './core/guard/route-guard';
import { HomeComponent } from './page/home/home.component';
import { GerenciaUserComponent } from './page/gerencia-user/gerencia-user.component';
import { GerenciaClienteComponent } from './page/gerencia-cliente/gerencia-cliente.component';


const routes: Routes = [
  {
    path: '', component: LoginComponent
  },
  {
    path: 'home', component: HomeComponent, canActivate:[RouteGuard], children:[
      {path: 'gerenciaUser', component: GerenciaUserComponent},
      {path: 'gerenciaCliente', component: GerenciaClienteComponent}
    ],
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
