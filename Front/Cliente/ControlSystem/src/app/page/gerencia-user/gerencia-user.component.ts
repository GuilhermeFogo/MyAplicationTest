import { Component, OnInit } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { error } from 'protractor';
import { LoginService } from 'src/app/module/users/service/login.service';
import { FormUserComponent } from 'src/app/module/users/form-user/form-user.component';
import { User } from 'src/app/module/users/modal/user';
import { MatTableDataSource } from '@angular/material/table';

@Component({
  selector: 'app-gerencia-user',
  templateUrl: './gerencia-user.component.html',
  styleUrls: ['./gerencia-user.component.scss']
})
export class GerenciaUserComponent implements OnInit {

  dataSource: MatTableDataSource<User>;
  displayedColumns: string[] = ['nome', 'senha', "Edit"];
  private dialog: MatDialog;
  private loginService: LoginService
  constructor(dialog: MatDialog, loginService: LoginService) {
    this.dialog = dialog;
    this.loginService = loginService;
  }

  // private dado = [
  //   new User({ nome: 'Guilherme', senha: '123456789', id: "0" })
  // ]

  ngOnInit(): void {
    this.getUser();

    // this.dataSource = new MatTableDataSource(this.dado);
  }

  public OpenDialog() {
    this.dialog.open(FormUserComponent, {
      width: '250px',
      data: null
    }).afterClosed().subscribe(result => {
      if (result != undefined) {
        this.postUser(result);
        this.getUser();
      }
    });
  }

  public EditDialog(user: User) {
    this.dialog.open(FormUserComponent, {
      width: '250px',
      data: user
    }).afterClosed().subscribe(result => {
      if (result != undefined) {
        this.putUser(result);
        this.getUser();
      }
    });
  }

  public deletaUser(user: User) {
    this.deleteUser(user);   
  }









  private getUser() {
    this.loginService.getUser().subscribe(
      x => { this.dataSource =  new MatTableDataSource(x)},
      error => console.error(error)
    );
  }


  private postUser(user: User) {
    this.loginService.postUser(user).subscribe(
      () => console.log("Cadastrado com Exito")

    )
  }

  private putUser(user: User) {
    this.loginService.putUser(user).subscribe(x => {
      console.log("Atualizado com exito");
    }, error => console.log(error))
  }

  private deleteUser(user: User) {
    this.loginService.deleteUser(user).subscribe(x => {
      console.log("Deletado com exito");
    }, error => console.log(error))
  }

}
