import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { EnderecoComponent } from './endereco.component';



@NgModule({
  declarations: [EnderecoComponent],
  imports: [
    CommonModule
  ], exports:[EnderecoComponent]
})
export class EnderecoModule { }
