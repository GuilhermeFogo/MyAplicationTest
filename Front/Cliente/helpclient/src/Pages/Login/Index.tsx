import React from 'react'
import { Usuarios } from "../../Modal/Usuario";
import "./index.css"
import foto from"../../logo.svg"
import {InputLogin} from "../../Componentes/Loguin/Inputs/index"


export class PageLoguin extends React.Component<any,Usuarios> {
    
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