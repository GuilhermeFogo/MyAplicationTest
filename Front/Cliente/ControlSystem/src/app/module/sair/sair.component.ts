import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { CookieService } from 'src/app/core/cookie/cookie.service';

@Component({
  selector: 'app-sair',
  templateUrl: './sair.component.html',
  styleUrls: ['./sair.component.scss']
})
export class SairComponent implements OnInit {

  private CookieService: CookieService
  private rota: Router;
  constructor(CookieServices: CookieService, rota: Router) {
    this.CookieService = CookieServices
    this.rota = rota;
  }



  public deletecookie() {
    this.CookieService.DeleteCookie("Session");
    this.rota.navigateByUrl("/");
  }
  
  ngOnInit(): void {

  }

}
