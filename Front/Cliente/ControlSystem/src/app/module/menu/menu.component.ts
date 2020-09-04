import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-menu',
  templateUrl: './menu.component.html',
  styleUrls: ['./menu.component.scss']
})
export class MenuComponent implements OnInit {
  public list_links: IMenus[];
  private rota: Router;

  constructor(rota: Router) {
    this.rota = rota;
  }

  ngOnInit(): void {
    this.list_links = [
      {
        titulo: 'Home',
        route: '/access/home',
        icon: 'home'
      },
      {
        titulo: 'Usuarios',
        route: 'access/gerenciaUser',
        display: false,
        icon: 'account_box'
      },
      {
        titulo: 'Clientes',
        route: 'access/gerenciaCliente',
        icon: 'accessibility_new',
        display: false
      }
    ]
  }


  public OnClick(rota: string) {
    this.rota.navigateByUrl(rota);
  }
}




export interface IMenus {
  titulo: string,
  icon?: string,
  route: string,
  display?: boolean
}
