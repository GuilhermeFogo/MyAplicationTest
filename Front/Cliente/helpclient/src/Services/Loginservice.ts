import { Cookies } from './../Cookies/cookies';
import React from 'react'
import axios from "axios";

export class LoguinService extends React.Component {
    private url: string
    private cookie: Cookies
    constructor(props: any) {
        super(props)
        this.cookie = new Cookies(props)
        this.url = "http://localhost:51528/api/Auth";
    }

    Login(nome: string, pass: string) {
        const user = {
            nome: nome,
            senha: pass
        }
        axios.post(this.url, user).then(res => {
            if (res.status == 200) {
                const exiires = this.cookie.Expires(0, 0, 2)
                this.cookie.CreateCookie(res.data, exiires)
            }
        }).catch(() => {
            alert("Algo de errado aconteceu")
        })
    }
}