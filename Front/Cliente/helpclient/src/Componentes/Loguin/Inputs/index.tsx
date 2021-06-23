import React from "react";
import { Usuarios } from "../../../Modal/Usuario";
import "./index.css"

export class InputLogin extends React.Component<any, Usuarios>{

    constructor(prop: any) {
        super(prop);

    }



    render() {
        return (
            <div className="ajuste">
                <form action="https://www.google.com/" method="get">
                    <div className="">
                        <div>
                            <input type="text" name="user" about="teste" placeholder="Usuario" className="input"/>
                        </div>
                        <div>
                            <input type="password" name="pass" about="teste" placeholder="123456" className="input"/>
                        </div>
                    </div>

                    <input type="submit" name="enviar" className="input-envio"/>
                </form>
            </div>
        )
    }
}




