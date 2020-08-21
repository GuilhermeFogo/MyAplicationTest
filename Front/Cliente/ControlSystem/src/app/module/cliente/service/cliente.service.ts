import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Cliente } from '../modal/cliente';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class ClienteService {
  private readonly http: HttpClient;
  private readonly url: string;
  constructor(http: HttpClient) {
    this.http = http;
    this.url = environment.Local.apiLocal + "api/Cliente";
   }

   public  VerClientes(): Observable<Cliente[]>{
     return this.http.get<Cliente[]>(this.url);
   }

   public  PostCliente(cliente: Cliente): Observable<Cliente>{
    return this.http.post<Cliente>(this.url, cliente);
  }

  public  PutCliente(cliente: Cliente): Observable<Cliente>{
    return this.http.put<Cliente>(this.url, cliente.Id);
  }

  public  DeleteCliente(): Observable<Cliente>{
    return this.http.delete<Cliente>(this.url);
  }
  
}
