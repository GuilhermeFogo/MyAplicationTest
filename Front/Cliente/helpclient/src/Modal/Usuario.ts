import React from "react-dom/node_modules/@types/react";

export class Usuarios {
    private id: string;
    private nome: string;
    private senha: string;
    private email: string;
    private ativado: boolean;
    private role: string;
    private roleString: string;


    
    public get Nome() : string {
        return this.nome;
    }

    
    public get RoleString() : string {
        return this.roleString;
    }
    
    
    public get Email() : string {
        return this.email;
    }
    
    
    public get Ativado() : boolean {
        return this.ativado;
    }
    

    
    public get Senha() : string {
        return this.senha;
    }
    
    
    public get Role() : string {
        return this.role;
    }
    

    constructor({id,nome, senha,email,ativado, role, roleString}: {id: string,nome: string, senha: string,email:string,ativado:boolean, role: string, roleString: string}){
        this.nome = nome;
        this.senha = senha;
        this.role = role;
        this.roleString = roleString;
        this.id = id;
        this.ativado = ativado;
        this.email = email;
    }

}