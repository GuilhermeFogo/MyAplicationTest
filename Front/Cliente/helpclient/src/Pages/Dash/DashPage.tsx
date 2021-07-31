import React from "react";
import "./dash.css"
import { Cookies } from "../../Cookies/cookies";
import { Header, Icon, Image, Menu, Segment, Sidebar } from 'semantic-ui-react'



export class DashPage extends React.Component<any, any> {
    private cookie: Cookies
    constructor(props: any) {
        super(props)
        this.cookie = new Cookies(props)
        this.existeCookie()
    }

    private existeCookie() {
        if (this.cookie.ExistCookie("Session") == false) {
            window.location.href = "/"
        }
    }



    render() {
        return (
            <div>
                <Sidebar.Pushable as={Segment}>
                    <Sidebar
                        as={Menu}
                        animation='overlay'
                        icon='labeled'
                        inverted
                        vertical
                        visible
                        width='thin'
                    >
                        <Menu.Item as='a'>
                            <Icon name='home' />
                            Home
                        </Menu.Item>
                        <Menu.Item as='a'>
                            <Icon name='gamepad' />
                            Games
                        </Menu.Item>
                        <Menu.Item as='a'>
                            <Icon name='camera' />
                            Channels
                        </Menu.Item>
                    </Sidebar>

                    <Sidebar.Pusher>
                        <Segment basic>
                            <Header as='h3'>Application Content</Header>
                            <Image src='/images/wireframe/paragraph.png' />
                        </Segment>
                    </Sidebar.Pusher>
                </Sidebar.Pushable>
            </div>
        );
    }
}