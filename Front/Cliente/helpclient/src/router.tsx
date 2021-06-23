import React from 'react'
import { BrowserRouter, Switch, Route } from 'react-router-dom';
import { PageLoguin } from './Pages/Login/Index';

export class Rotas extends React.Component<any, any>{

    render() {
        return (
            <BrowserRouter>
                <Switch>
                    <Route exact path="/" component={PageLoguin} />
                </Switch>
            </BrowserRouter>
        );
    }
}

export default Rotas;