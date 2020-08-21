import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { LoginModule } from './page/login/login.module';
import { HomeModule } from './page/home/home.module';
import { GerenciaUserModule } from './page/gerencia-user/gerencia-user.module';
import { GerenciaClienteModule } from './page/gerencia-cliente/gerencia-cliente.module';

@NgModule({
  declarations: [
    AppComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    LoginModule,
    HomeModule,
    GerenciaUserModule,
    GerenciaClienteModule
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
