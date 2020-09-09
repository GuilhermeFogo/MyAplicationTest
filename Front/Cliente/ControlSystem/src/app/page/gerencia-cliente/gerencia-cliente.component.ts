import { Component, OnInit } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { FormClienteComponent } from 'src/app/module/cliente/component/form-cliente/form-cliente.component';
import { Cliente } from 'src/app/module/cliente/modal/cliente';
import { MatTableDataSource } from '@angular/material/table';

@Component({
  selector: 'app-gerencia-cliente',
  templateUrl: './gerencia-cliente.component.html',
  styleUrls: ['./gerencia-cliente.component.scss']
})
export class GerenciaClienteComponent implements OnInit {

  dataSource: MatTableDataSource<Cliente>;
  displayedColumns: string[] = ['nome', 'email','telefone','rua', 'CEP', 'cidade','estado' , "Edit"];
  private dialog: MatDialog
  constructor(dialog: MatDialog) {
    this.dialog = dialog;
   }
  ngOnInit(): void {

  }


   public OpenDialog(){
     this.dialog.open(FormClienteComponent,{
       width:'500px',
       data: null
     }).afterClosed().subscribe(x=>{
       console.log(x);
     })
   }


   public EditDialog(cliente: Cliente){

   }

   public deletaCliente(cliente: Cliente){

   }


   
}
