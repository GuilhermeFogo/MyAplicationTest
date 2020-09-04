import { Component, OnInit } from '@angular/core';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { User } from '../modal/user';
import { LoginService } from '../service/login.service';
import { CookieService } from 'src/app/core/cookie/cookie.service';

@Component({
  selector: 'app-form-login',
  templateUrl: './form-login.component.html',
  styleUrls: ['./form-login.component.scss']
})
export class FormLoginComponent implements OnInit {

  form: FormGroup;
  private fb: FormBuilder;
  private route: Router;
  private loginservice: LoginService;
  private cookie: CookieService;
  constructor(fb: FormBuilder, route: Router, loginservice: LoginService, cookie: CookieService) {
    this.fb = fb;
    this.route = route;
    this.loginservice = loginservice;
    this.cookie = cookie;
  }


  public get f() {
    return this.form.controls;
  }

  ngOnInit(): void {
    this.form = this.fb.group({
      nameUser: ['', [Validators.required]],
      pass: ['', [Validators.required, Validators.minLength(6)]]
    });
  }

  public OnSubmit() {
    const user = new User({
      nome: this.f.nameUser.value,
      senha: this.f.pass.value,
      id: "0",
      email: null,
      ativado:true
    });
    const expires = this.cookie.Expires(0,0,2);
    // this.loginservice.loginUser(user).subscribe(x => {
    //   this.cookie.CreateCookie(x.Nome, expires);
    //   this.route.navigateByUrl('/home');
    // }, erro => console.error(erro));
    this.cookie.CreateCookie(user.Nome, expires);
    this.route.navigateByUrl('/access/home');
  }

}
