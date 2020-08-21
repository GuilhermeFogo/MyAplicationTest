import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class CookieService {

  public CreateCookie(value: any, expires: string) {
    document.cookie = 'Session=' + value + ';expires=' + expires + ';path=/';
  };

  public ExistCookie(CoookieName: string): boolean {
    if (this.getCookie(CoookieName)) {
      return true;
    }
    return false;
  }

  private getCookie(cname): boolean {
    const name = cname + "=";
    let decodedCookie = decodeURIComponent(document.cookie);
    const ca = decodedCookie.split(';');
    for (let i = 0; i < ca.length; i++) {
      var c = ca[i];
      while (c.charAt(0) == ' ') {
        c = c.substring(1);
      }
      if (c.indexOf(name) == 0) {
        return true
      }
    }
    return false;
  }


  public getValueCookie(cname): string {
    const name = cname + "=";
    let decodedCookie = decodeURIComponent(document.cookie);
    const ca = decodedCookie.split(';');
    for (let i = 0; i < ca.length; i++) {
      var c = ca[i];
      while (c.charAt(0) == ' ') {
        c = c.substring(1);
      }
      if (c.indexOf(name) == 0) {
        return c.substring(name.length, c.length);
      }
    }
    return null;
  }

  public Expires(dia?: number, minuto?: number, hora?: number): string {
    const date = new Date();
    date.setDate(date.getDate() + dia)
    date.setMinutes(date.getMinutes() + minuto)
    date.setHours(date.getHours() + hora);
    return date.toUTCString()
  }
}
