import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { User } from '../modal/user';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class LoginService {
private http: HttpClient
private url: string;
  constructor(http: HttpClient) {
    this.http = http;
    this.url =environment.Local.apiLocal + "api/Usuario";
   }


   getUser(): Observable<User[]>{
     return this.http.get<User[]>(this.url);
   }

   postUser(user: User): Observable<User>{
     console.log("scusahcuis");
    return this.http.post<User>(this.url,user);
  }

  putUser(user: User): Observable<User>{
    return this.http.put<User>(this.url,user);
  }

  deleteUser(user: User): Observable<User>{
    return this.http.delete<User>(this.url + user.Id);
  }

  loginUser(u:User): Observable<User>{
    return this.http.post<User>(this.url, u);
  }
}
