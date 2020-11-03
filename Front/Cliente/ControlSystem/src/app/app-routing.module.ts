import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { LoginComponent } from './page/login/login.component';
import { RouteGuard } from './core/guard/route-guard';
import { HomeComponent } from './page/home/home.component';
import { GerenciaUserComponent } from './page/gerencia-user/gerencia-user.component';
import { GerenciaClienteComponent } from './page/gerencia-cliente/gerencia-cliente.component';
import { PageErrorComponent } from './page/page-error/page-error.component';
import { AccessComponent } from './module/access/access.component';
import { BlockUserGuard } from './core/guard/block-user-guard';


const routes: Routes = [
  {
    path: '', component: LoginComponent, canActivate:[BlockUserGuard]
  },
  {
    path: 'access', component: AccessComponent, canActivate:[RouteGuard], children:[
      {path: 'home', component: HomeComponent},
      
      {path: 'gerenciaUser', component: GerenciaUserComponent},
      {path: 'gerenciaCliente', component: GerenciaClienteComponent},
      {path:'**', component:PageErrorComponent}
    ],
  },
  {path:'**', component:PageErrorComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
