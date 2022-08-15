import React, { Component } from 'react';

export class BYOB extends Component {
    static displayName = BYOB.name;

    constructor(props) {
        super(props);
        //this.state = { currentCount: 0 };
        //this.incrementCounter = this.incrementCounter.bind(this);
        this.state = { viewModel: [] }

    }
    componentDidMount() {
        this.populateBurgerData();
    }

    incrementCounter() {
        this.setState({
            currentCount: this.state.currentCount + 1
        });
    }

    render() {
        return (
            //start parent div
            <div> 
                <h1>Build Your Own Burger</h1>

                <p>This is a simple example of a BYOB component.</p>
                <p>This is a not so simple example of a BYOB component.</p>

                <p aria-live="polite">Current Burgers: <strong>{this.state.currentCount}</strong></p>

                <button className="btn btn-primary" onClick={this.incrementCounter}>Aik Aur!</button>


            </div>//end parent div


        );
    }

    async populateBurgerData() {
        const response = await fetch('api/Burger/MakeBurger');
        const data = await response.text();
        this.setState({ viewModel: data });
        console.log("data view:", this.state.viewModel);
        console.log("data:", data);
    }
}
