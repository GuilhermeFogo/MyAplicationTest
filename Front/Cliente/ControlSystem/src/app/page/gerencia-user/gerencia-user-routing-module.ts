import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { GerenciaUserComponent } from './gerencia-user.component';

const routes: Routes = [
    {path:'', component: GerenciaUserComponent}
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class GerenciaUserRoutingModule { }
