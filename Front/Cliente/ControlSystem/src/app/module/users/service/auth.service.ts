import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { User } from '../modal/user';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class AuthService {
  private http: HttpClient
  private url: string;
  constructor(http: HttpClient) {
    this.http = http;
    this.url =environment.Local.apiLocal + "api/Auth/";
   }

  loginUser(u:User): Observable<User>{
    const myheader = new HttpHeaders().set('Content-Type', 'application/json; charset=utf-8');
    return this.http.post<User>(this.url, u,{
      headers: myheader,
      observe:'body',
      responseType: 'text' as 'json'
    });
  }
}
