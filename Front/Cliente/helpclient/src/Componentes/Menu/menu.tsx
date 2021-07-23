import { any } from "prop-types";
import React from "react";
import { Link } from "react-router-dom";
import Rotas from "../../router";

export class MenuCompoent extends React.Component{

    constructor(prop: any){
        super(prop)
    }

    render() {
        return (
             <div>
                 <ul>
                     <li>
                         <Link to ="/Dash">Inicio</Link>
                     </li>
                     <li>
                         <Link to ="/HelpDesk">HelpDesk</Link>
                     </li>
                 </ul>
             </div>
        );
    }

}