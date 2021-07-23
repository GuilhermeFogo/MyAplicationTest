import React from "react";
export class UsuarioDTO{
    nome: string
    pass: string

    
    public get Pass() : string {
        return this.pass
    }

    
    public get Nome() : string {
        return this.nome
    }
    
    
    constructor({nome, pass}:{nome: string, pass: string}){
        this.nome = nome
        this.pass = pass
    }
}