import { CanActivate, ActivatedRouteSnapshot, RouterStateSnapshot, Router } from '@angular/router';
import { Injectable } from '@angular/core';
import { CookieService } from '../cookie/cookie.service';


@Injectable({
    providedIn: 'root'
  })
export class RouteGuard implements CanActivate {
    private cooke: CookieService
    private Router: Router
    constructor(cookie: CookieService, Router: Router){
        this.cooke = cookie
        this.Router = Router;
    }
    canActivate(route: ActivatedRouteSnapshot, state: RouterStateSnapshot): boolean {
        if(this.cooke.ExistCookie('Session')){
            return true;
        }else{
            this.Router.navigateByUrl('');
            return false;
        }
    }
}
