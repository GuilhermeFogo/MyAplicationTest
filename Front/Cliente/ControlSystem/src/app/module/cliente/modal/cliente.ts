export class Cliente {
    private readonly nome: string;
    private readonly id: number;
    private readonly telefones: string;
    private readonly emails: string;


    
    public get Nome() : string {
        return this.nome;
    }

    
    public get Id() : number {
        return this.id;
    }

    
    public get Telefones() : string {
        return this.telefones;
    }

    
    public get Email() : string {
        return this.emails;
    }
    

    constructor({ id, nome, telefones, emails }: 
        { id: number, nome: string, telefones: string, emails: string }) {
            this.emails = emails;
            this.id = id;
            this.nome = nome;
            this.telefones = telefones;
    }
}
