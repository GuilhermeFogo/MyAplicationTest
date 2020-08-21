import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { HomeRoutingModule } from './home-routing.module';
import { HomeComponent } from './home.component';
import { GerenciaUserModule } from '../gerencia-user/gerencia-user.module';
import { MenuModule } from 'src/app/module/menu/menu.module';
import {MatSidenavModule} from '@angular/material/sidenav';
import { RouterModule } from '@angular/router';
@NgModule({
  declarations: [HomeComponent],
  imports: [
    CommonModule,
    HomeRoutingModule,
    GerenciaUserModule,
    MenuModule,
    MatSidenavModule,
    RouterModule
  ]
})
export class HomeModule { }
