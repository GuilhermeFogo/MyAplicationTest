import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
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
    return this.http.post<User>(this.url, u);
  }
}
