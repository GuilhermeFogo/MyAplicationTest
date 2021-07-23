import React from "react";
import { Cookies } from "../../Cookies/cookies";


export class DashPage extends React.Component<any,any> {
   private cookie: Cookies
    constructor(props: any) {
        super(props)
        this.cookie = new Cookies(props)
        this.existeCookie()
    }

    private existeCookie(){
        if (this.cookie.ExistCookie("Session") == false) {
            window.location.href ="/"
        }
    }
    
    render() {
        return (
             <div>
                 
             </div>
        );
    }
}