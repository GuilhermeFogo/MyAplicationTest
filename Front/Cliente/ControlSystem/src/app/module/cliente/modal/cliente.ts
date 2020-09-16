import { Endereco } from '../../endereco/modal/endereco';

export class Cliente {
    readonly nome: string;
    readonly id_Cliente: string;
    readonly telefone: string;
    readonly email: string;

    readonly endereco: Endereco;


    
    public get Nome() : string {
        return this.nome;
    }

    
    public get Id() : string {
        return this.id_Cliente;
    }

    
    public get Telefones() : string {
        return this.telefone;
    }

    
    public get Email() : string {
        return this.email;
    }

    
    public get Endereco() : Endereco {
        return this.endereco
    }
    
    

    constructor({ id_Cliente, nome, telefone, email, 
        idEndereco, cep, complemento, estado, cidade, rua, bairro }: 
        { id_Cliente: string, nome: string, telefone: string, email: string , 
            idEndereco: string, cep: string, cidade: string, complemento:string, 
            estado: string, rua: string, bairro: string}) {
            this.email = email;
            this.id_Cliente = id_Cliente;
            this.nome = nome;
            this.telefone = telefone;
            this.endereco = new Endereco({
                idEndereco: idEndereco,
                cep:  cep,
                cidade: cidade,
                complemento: complemento,
                estado: estado,
                rua: rua,
                bairro: bairro
            })
    }
}
