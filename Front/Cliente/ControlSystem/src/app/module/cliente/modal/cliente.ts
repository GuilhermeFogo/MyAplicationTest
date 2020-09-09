import { Endereco } from '../../endereco/modal/endereco';

export class Cliente {
    private readonly nome: string;
    private readonly id: number;
    private readonly telefones: string;
    private readonly emails: string;

    private readonly enderco: Endereco;


    
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

    
    public get Endereco() : Endereco {
        return this.enderco
    }
    
    

    constructor({ id, nome, telefones, emails, 
        idEndereco, cep, complemento, estado, cidade, rua }: 
        { id: number, nome: string, telefones: string, emails: string , 
            idEndereco: string, cep: string, cidade: string, complemento:string, 
            estado: string, rua: string}) {
            this.emails = emails;
            this.id = id;
            this.nome = nome;
            this.telefones = telefones;
            this.enderco = new Endereco({
                idEndereco: idEndereco,
                cep:  cep,
                cidade: cidade,
                complemento: complemento,
                estado: estado,
                rua: rua
            })
    }
}
