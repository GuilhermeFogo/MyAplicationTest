import { Injectable } from '@angular/core';
import { ActivatedRouteSnapshot, CanActivate, Router, RouterStateSnapshot, UrlTree } from '@angular/router';
import { Observable } from 'rxjs';
import { CookieService } from '../cookie/cookie.service';

@Injectable({
  providedIn: 'root'
})
export class BlockUserGuard implements CanActivate {
  private cooke: CookieService;
  private Router: Router;
  constructor(cookie: CookieService, Router: Router) {
    this.cooke = cookie
    this.Router = Router;
  }
  canActivate(route: ActivatedRouteSnapshot, state: RouterStateSnapshot): boolean {
    if (this.cooke.ExistCookie('Session')) {
      this.Router.navigateByUrl('access/home');
      return false
    } else {
      return true;
    }
  }
}
