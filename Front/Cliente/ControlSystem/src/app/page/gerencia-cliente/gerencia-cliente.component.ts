import { Component, OnInit } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { FormClienteComponent } from 'src/app/module/cliente/component/form-cliente/form-cliente.component';
import { Cliente } from 'src/app/module/cliente/modal/cliente';
import { MatTableDataSource } from '@angular/material/table';
import { ClienteService } from 'src/app/module/cliente/service/cliente.service';

@Component({
  selector: 'app-gerencia-cliente',
  templateUrl: './gerencia-cliente.component.html',
  styleUrls: ['./gerencia-cliente.component.scss']
})
export class GerenciaClienteComponent implements OnInit {

  dataSource: MatTableDataSource<Cliente>;
  displayedColumns: string[] = ['nome', 'email', 'telefone', 'rua', 'CEP', 'cidade', 'estado', "Edit"];
  private dialog: MatDialog;
  private clienteService: ClienteService;
  constructor(dialog: MatDialog, clienteService: ClienteService) {
    this.dialog = dialog;
    this.clienteService = clienteService;
  }
  ngOnInit(): void {
    this.getClientes();
  }


  public OpenDialog() {
    this.dialog.open(FormClienteComponent, {
      width: '500px',
      data: null
    }).afterClosed().subscribe(x => {
      if(x !=undefined){
        this.PostClientes(x)
        this.getClientes();
      }
      this.getClientes();

    })
  }


  public EditDialog(cliente: Cliente) {
    this.dialog.open(FormClienteComponent, {
      width: '500px',
      data: cliente
    }).afterClosed().subscribe(x => {
      if(x !=undefined){
        this.PutClientes(x);
        console.log(x);
        
        this.getClientes();
      }
      this.getClientes();

    })
  }

  public deletaCliente(cliente: Cliente) {
    this.DeleteClientes(cliente);
  }

  private getClientes(){
    this.clienteService.VerClientes().subscribe(x=>{
      this.dataSource = new MatTableDataSource(x); 
    }, erro => console.error(erro))
  }

  private PostClientes(cliente: Cliente){
    this.clienteService.PostCliente(cliente).subscribe(()=>{ 
      console.log("Enviado com exito");
    }, erro => console.error(erro))
  }

  private PutClientes(cliente: Cliente){
    this.clienteService.PutCliente(cliente).subscribe(()=>{ 
      console.log("Alteração salva com exito");
    }, erro => console.error(erro))
  }

  private DeleteClientes(cliente: Cliente){
    this.clienteService.DeleteCliente(cliente).subscribe(()=>{ 
      console.log("Deletado com exito");
    }, erro => console.error(erro))
  }



}
