import { Component, OnInit } from '@angular/core';
import { EnderecoService } from '../service/endereco.service';
import { Endereco } from '../modal/endereco';

@Component({
  selector: 'app-endereco',
  templateUrl: './endereco.component.html',
  styleUrls: ['./endereco.component.scss']
})
export class EnderecoComponent implements OnInit {

  private endereco: Endereco
  private enderecoService:EnderecoService;
  constructor(enderecoService:EnderecoService) {
    this.enderecoService = enderecoService
   }


   // terminar de criar campos, e criar o component endereco
  ngOnInit(): void {
    
  }


  private getCEP(){
    this.enderecoService.getCEP("09030000").subscribe(x=>{
      console.log(x);
    },error =>{console.log(error)})
  }

}
