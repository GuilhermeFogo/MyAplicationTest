import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { EnderecoComponent } from './endereco.component';
import { MatButtonModule } from '@angular/material/button';
import { ReactiveFormsModule } from '@angular/forms';
import { MatInputModule } from '@angular/material/input';



@NgModule({
  declarations: [EnderecoComponent],
  imports: [
    CommonModule,
  ], exports:[EnderecoComponent]
})
export class EnderecoModule { }
