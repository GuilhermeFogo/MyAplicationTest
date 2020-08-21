export class User {
    readonly id: string
    readonly nome: string;
    readonly senha: string;
    readonly email: string;
    readonly ativo: boolean;

    public get Nome(): string {
        return this.nome;
    }

    public get Senha(): string {
        return this.senha;
    }


    public get Email(): string {
        return this.email;
    }


    public get Ativo(): boolean {
        return this.ativo;
    }


    public get Id(): string {
        return this.id;
    }


    constructor({ nome, senha, id, email, ativo }: { nome: string, senha: string, id: string, email: string, ativo: boolean }) {
        this.nome = nome;
        this.senha = senha;
        this.id = id;
        this.ativo = ativo;
        this.email = email;
    }
}
