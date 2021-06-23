import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { SairComponent } from './sair.component';
import { MatButtonModule } from '@angular/material/button';
import {MatIconModule} from '@angular/material/icon';



@NgModule({
  declarations: [SairComponent],
  imports: [
    CommonModule,
    MatButtonModule,
    MatIconModule
  ], 
  exports:[SairComponent]
})
export class SairModule { }
