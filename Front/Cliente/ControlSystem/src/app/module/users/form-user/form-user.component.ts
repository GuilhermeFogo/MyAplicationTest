import { Component, OnInit, Inject } from '@angular/core';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { MAT_DIALOG_DATA, MatDialog, MatDialogRef } from '@angular/material/dialog';
import { User } from '../modal/user';

@Component({
  selector: 'app-form-user',
  templateUrl: './form-user.component.html',
  styleUrls: ['./form-user.component.scss']
})
export class FormUserComponent implements OnInit {

  form: FormGroup;
  CreateEdit: string;
  private fb: FormBuilder;
  private dialogRef: MatDialogRef<FormUserComponent>;
  constructor(fb: FormBuilder, @Inject(MAT_DIALOG_DATA) public data: User, dialogRef: MatDialogRef<FormUserComponent>) {
    this.fb = fb;
    this.dialogRef = dialogRef;
    this.dialogRef.disableClose = true;
  }


  public get f() {
    return this.form.controls;
  }

  ngOnInit(): void {
    if (!this.data) {
      this.CreateEdit = "Criando";
      this.form = this.fb.group({
        nome: ['', [Validators.required]],
        senha: ['', [Validators.required, Validators.minLength(6)]],
        id: [''],
        email:['',[Validators.required, Validators.email]],
        ativado:[true,[Validators.required]],
        role: [1, [Validators.required]]
      })
    } else {
      this.CreateEdit = "Editando";
      this.form = this.fb.group({
        nome: [this.data.nome, [Validators.required]],
        senha: [this.data.senha, [Validators.required, Validators.minLength(6)]],
        email:[this.data.email,[Validators.required, Validators.email]],
        ativado:[this.data.ativado,[Validators.required]],
        id: [this.data.id],
        role: [this.data.roles, [Validators.required]]
      })
    }
  }


  public Onsubmit() {
    console.log(this.MyUser());
    
    this.dialogRef.close(this.MyUser());
  }

  public Close() {
    this.dialogRef.close(undefined);
  }


  private MyUser(): User {
    if (!this.data) {
      const newUser = new User({
        nome: this.f.nome.value,
        senha: this.f.senha.value,
        id: "0",
        email: this.f.email.value,
        ativado: this.f.ativado.value,
        roles: this.f.role.value,
        roleString: null
      })
      console.log(newUser);
      
      return newUser;
    } else {
      const editUser = new User({
        nome: this.f.nome.value,
        senha: this.f.senha.value,
        id: this.f.id.value,
        email: this.f.email.value,
        ativado: this.f.ativado.value,
        roles: this.f.role.value,
        roleString: null
      })
      return editUser;
    }
  }
}
