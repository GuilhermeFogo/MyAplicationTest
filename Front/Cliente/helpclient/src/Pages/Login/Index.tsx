import React from 'react'
import { Usuarios } from "../../Modal/Usuario";
import "./index.css"
import foto from"../../logo.svg"
import {InputLogin} from "../../Componentes/Loguin/Inputs/index"
import { Cookies } from '../../Cookies/cookies';


export class PageLoguin extends React.Component<any,Usuarios> {

    private cookie: Cookies
    constructor(prop: any){
        super(prop)
        this.cookie = new Cookies(prop)
        this.existCookie()
    }

    private existCookie() {
        if (this.cookie.ExistCookie("Session") == false) {
            console.log("atualiza");
        } else {
            console.log("troca de pagina");
            window.location.href ="/HelpDesk"
        }
    }

    render(){
        return(
            <div className="div">
                <section className="section">
                    <img className="img" src={foto} alt="foto"/>
                    <p  className="p">Seja Bem Vindo ao HelpClient</p>
                </section>
                <section className="section1">
                     <InputLogin></InputLogin>
                </section>
            </div>
        )
    }
}