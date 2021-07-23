import React from "react";
import "./index.css"
import { LoguinService } from "../../../Services/Loginservice"
import { Cookies } from "../../../Cookies/cookies";

export class InputLogin extends React.Component<any, any>{
    readonly testes: LoguinService;
    private cookie: Cookies;
    constructor(prop: any) {
        super(prop);
        this.state = { nome: "", pass: "" };
        this.testes = new LoguinService(prop)
        this.cookie = new Cookies(prop);
        this.definevalor = this.definevalor.bind(this);
        this.Submit = this.Submit.bind(this);
        this.definepass = this.definepass.bind(this)
    }

    definevalor(event: any) {
        this.setState(
            {
                nome: event.target.value
            });
    }

    definepass(event: any) {
        this.setState({
            pass: event.target.value
        })
    }

    Submit(event: any) {
        this.testes.Login(this.state.nome, this.state.pass)
        
        if (this.cookie.ExistCookie("Session") != false) {
            window.location.href ="/Dash"
        }
        event.preventDefault();
    }


    render() {
        return (
            <div className="ajuste">
                <form method="post" autoComplete="off" onSubmit={this.Submit}>
                    <div>
                        <div>
                            <input type="text" name="user" placeholder="Usuario" className="input" onChange={this.definevalor} />
                        </div>
                        <div>
                            <input type="password" name="pass" placeholder="123456" className="input" onChange={this.definepass} />
                        </div>
                    </div>

                    <input type="submit" name="enviar" className="input-envio" />
                </form>
            </div>
        )
    }
}




