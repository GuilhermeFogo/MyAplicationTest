import { Component, OnInit, Input } from '@angular/core';
import { EnderecoService } from '../service/endereco.service';
import { Endereco } from '../modal/endereco';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-endereco',
  templateUrl: './endereco.component.html',
  styleUrls: ['./endereco.component.scss']
})
export class EnderecoComponent implements OnInit {

  
  constructor() {
   
  }


  // public get f() {
  //   return this.form.controls;
  // }


  ngOnInit(): void {
    // this.form = this.FormBranco();
  }

  // public Onsubmit() {
  //   const endereco = new Endereco({
  //     cep: this.f.cep.value,
  //     cidade: this.f.cidade.value,
  //     complemento: this.f.complemento.value,
  //     estado: this.f.estado.value,
  //     idEndereco: this.f.id_Endereco.value,
  //     rua: this.f.rua.value
  //   })
    
  //   this.getCEP(endereco.cep)
  // }

  // private FormBranco() {
  //   return this.fb.group({
  //     rua: ['', [Validators.required]],
  //     cep: ['', [Validators.required, Validators.maxLength(8)]],
  //     cidade: ['', Validators.required],
  //     estado: ['', Validators.required],
  //     complemento: [''],
  //     id_Endereco: ['', Validators.required]
  //   });
  // }

  // private FormPreenchido(id: string, objeto: any) {
  //   return this.fb.group({
  //     rua: [objeto.logradouro, [Validators.required]],
  //     cep: [objeto.cep, [Validators.required, Validators.maxLength(8)]],
  //     cidade: [objeto.localidade, Validators.required],
  //     estado: [objeto.uf, Validators.required],
  //     complemento: [objeto.complemento],
  //     id_Endereco: [id, Validators.required]
  //   });
  // }

  // private getCEP(cepvalue: string) {
  //   this.enderecoService.getCEP(cepvalue).subscribe(x => {
  //     console.log(x);
  //     if (!this.id_Endereco) {
  //       this.form = this.FormPreenchido("0", x)
  //     } else {
  //       this.form = this.FormPreenchido(this.id_Endereco, x)
  //     }

  //   }, error => { console.log(error) })
  // }

}
