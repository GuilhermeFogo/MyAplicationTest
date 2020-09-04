export class User {
    readonly id: string
    readonly nome: string;
    readonly senha: string;
    readonly email: string;
    readonly ativado: boolean;

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


    constructor({ nome, senha, id, email, ativado }: { nome: string, senha: string, id: string, email: string, ativado: boolean }) {
        this.nome = nome;
        this.senha = senha;
        this.id = id;
        this.ativado = ativado
        this.email = email;
    }
}
