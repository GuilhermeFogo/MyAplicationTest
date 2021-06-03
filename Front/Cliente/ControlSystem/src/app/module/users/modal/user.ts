export class User {
    readonly id: string
    readonly nome: string;
    readonly senha: string;
    readonly email: string;
    readonly ativado: boolean;
    readonly roles: string;
    readonly roleString: string;

    public get Nome(): string {
        return this.nome;
    }

    public get Senha(): string {
        return this.senha;
    }


    public get Email(): string {
        return this.email;
    }


    public get Ativado(): boolean {
        return this.ativado;
    }


    public get Id(): string {
        return this.id;
    }

    public get Roles(): string {
        return this.roles;
    }
    
    public get RolesString(): string {
        return this.roleString;
    }


    constructor({ nome, senha, id, email, ativado, roles, roleString }: { nome: string, senha: string, id: string, email: string, ativado: boolean, roles:string, roleString: string}) {
        this.nome = nome;
        this.senha = senha;
        this.id = id;
        this.ativado = ativado
        this.email = email;
        this.roles = roles;
        this.roleString = roleString;
    }
}
