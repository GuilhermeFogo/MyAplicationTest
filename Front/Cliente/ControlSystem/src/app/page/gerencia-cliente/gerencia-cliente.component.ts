import { Component, OnInit } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { FormClienteComponent } from 'src/app/module/cliente/component/form-cliente/form-cliente.component';

@Component({
  selector: 'app-gerencia-cliente',
  templateUrl: './gerencia-cliente.component.html',
  styleUrls: ['./gerencia-cliente.component.scss']
})
export class GerenciaClienteComponent {

  private dialog: MatDialog
  constructor(dialog: MatDialog) {
    this.dialog = dialog;
   }


   public OpenDialog(){
     this.dialog.open(FormClienteComponent,{
       width:'250px',
       data: null
     }).afterClosed().subscribe(x=>{
       console.log(x);
     })
   }
   
}
