import React from 'react'
import { BrowserRouter, Switch, Route, Router } from 'react-router-dom';
import { DashPage } from './Pages/Dash/DashPage';
import { HelpDeskPage } from './Pages/Helpdesk';
import { PageLoguin } from './Pages/Login/Index';

export class Rotas extends React.Component<any, any>{


    constructor(props: any){
        super(props)
        this.state= {
            login: "/",
            helpdesk: "/HelpDesk",
            dash: "/Dash" 
        }
    }
    render() {
        return (
            <BrowserRouter>
                <Switch>
                    <Route exact path={this.state.login} component={PageLoguin} />
                    <Route exact path={this.state.helpdesk} component={HelpDeskPage} />
                    <Route exact path={this.state.dash} component ={DashPage}/>
                </Switch>
            </BrowserRouter>
        );
    }
}

export default Rotas;