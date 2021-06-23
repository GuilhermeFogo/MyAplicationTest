import { SairModule } from './../sair/sair.module';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { AccessComponent } from './access.component';
import { RouterModule } from '@angular/router';
import { MatSidenavModule } from '@angular/material/sidenav';
import { MenuModule } from '../menu/menu.module';



@NgModule({
  declarations: [AccessComponent],
  imports: [
    CommonModule,
    MenuModule,
    MatSidenavModule,
    RouterModule,
    SairModule
  ], exports:[AccessComponent]
})
export class AccessModule { }
