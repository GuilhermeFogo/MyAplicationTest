import { Router } from '@angular/router';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.scss']
})
export class HomeComponent implements OnInit {

  public HomeConfig: MyHome[]
  private router: Router
  constructor(router: Router) {
    this.router = router;
   }

  ngOnInit(): void {
    this.HomeConfig =[
      {
        nomeButton: "Gerenciar Usuario",
        route: "access/gerenciaUser"
      },
      {
        nomeButton: "Gerenciar Cliente",
        route:"access/gerenciaCliente"
      }
    ]
  }

  public onClick(item:string){
    this.router.navigateByUrl(item);
  }

}

interface MyHome{
  nomeButton: string,
  route: string;
}
