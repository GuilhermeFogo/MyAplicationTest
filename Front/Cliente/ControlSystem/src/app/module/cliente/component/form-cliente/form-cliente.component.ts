import { Component, OnInit, Inject } from '@angular/core';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { Cliente } from '../../modal/cliente';

@Component({
  selector: 'app-form-cliente',
  templateUrl: './form-cliente.component.html',
  styleUrls: ['./form-cliente.component.scss']
})
export class FormClienteComponent implements OnInit {

  form: FormGroup;
  CreateEdit: string;
  private fb: FormBuilder;
  private dialogRef: MatDialogRef<FormClienteComponent>;
  constructor(fb: FormBuilder, @Inject(MAT_DIALOG_DATA) public data: Cliente, dialogRef: MatDialogRef<FormClienteComponent>) {
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
        telefone: ['', [Validators.required]],
        id: [''],
        email: ['', [Validators.required, Validators.email]]
      })
    } else {
      this.CreateEdit = "Editando";
      this.form = this.fb.group({
        nome: [this.data.Nome, [Validators.required]],
        telefone: [this.data.Telefones, [Validators.required]],
        id: [this.data.Id],
        email: [this.data.Email, [Validators.required, Validators.email]]
      })
    }
  }


  public Onsubmit() {
    this.dialogRef.close(this.MyClient());
  }

  public Close() {
    this.dialogRef.close(undefined);
  }


  private MyClient(): Cliente {
    if (!this.data) {
      const newCliente = new Cliente({
        nome: this.f.nome.value,
        id: 0,
        telefones : this.f.telefone.value,
        emails: this.f.email.value
      })
      return newCliente;
    } else {
      const editCliente = new Cliente({
        nome: this.f.nome.value,
        telefones: this.f.telefone.value,
        emails: this.f.email.value,
        id: this.f.id.value
      })
      return editCliente;
    }
  }

}
