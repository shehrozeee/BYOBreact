import React, { Component } from 'react';
import Button from 'react-bootstrap/Button';
import Form from 'react-bootstrap/Form';
import 'bootstrap/dist/css/bootstrap.min.css';

export class BYOB extends Component {
    static displayName = BYOB.name;

    constructor(props) {
        super(props);
        //this.state = { currentCount: 0 };
        //this.incrementCounter = this.incrementCounter.bind(this);
        this.state = { viewModel: { meat: [], vegetables: [], sauces: [], burgerMuffins: [], Burger:[] } }
    }
    componentDidMount() {
        this.populateBurgerData();
    }

    incrementCounter() {
        this.setState({
            currentCount: this.state.currentCount + 1
        });

        console.log(this.state.viewModel);
    }

    //render() {
    //    return (
    //        <><button className="btn btn-primary" onClick={this.incrementCounter}>Increment</button>
    //            <Form>
    //                {/*<p>{this.state.viewModel.burgerMuffins[1].name}</p>*/}
    //                {/*<p>{this.state.name}</p>*/}
    //                <Form.Group className="mb-3" controlId="formBasicEmail">
    //                    <Form.Label>Burger Name</Form.Label>
    //                    <Form.Control type="text" placeholder="Enter your Burger Name" />
    //                </Form.Group>

    //                <Form.Select aria-label="Default select example">
    //                    {/*{this.state.meat.map(m =>*/}
    //                    {/*    <tr key={m.id}>*/}
    //                    {/*        <option>{m.name}</option>*/}
    //                    {/*    </tr>*/}
    //                    {/*)}*/}

    //                </Form.Select>

    //                <Form.Select aria-label="Default select example">
    //                    <option>Open this select menu</option>
    //                    <option value="1">one</option>
    //                    <option value="2">Two</option>
    //                    <option value="3">Three</option>
    //                </Form.Select>

    //                <Form.Group className="mb-3" controlId="formBasicCheckbox">
    //                    <Form.Check type="checkbox" label="With Cheese" />
    //                </Form.Group>

    //                <Button variant="primary" type="submit">
    //                    Submit
    //                </Button>

    //            </Form></>
    //    );
    //}

    static renderForecastsTable(meat) {
        return (
            <table className='table table-striped' aria-labelledby="tabelLabel">
                <thead>
                    <tr>
                        <th>Name</th>
                    </tr>
                </thead>
                <tbody>
                    {meat.map(m =>
                        <tr key={m.id}>
                            <td>{m.name}</td>
                        </tr>
                    )}
                </tbody>
            </table>
        );
    }

    render() {

        let contents = BYOB.renderForecastsTable(this.state.viewModel.meat);

        return (
            <div>
                <h1 id="tabelLabel" >Weather forecast</h1>
                <p>This component demonstrates fetching data from the server.</p>
                {contents}
            </div>
        );
    }

    async populateBurgerData() {
        const response = await fetch('api/Burger/GetBurgerItems');
        const data = await response.json();
        this.setState({ viewModel: data, meat: data.meats, vegetables: data.vegetables, sauces: data.sauces, burgerMuffins: data.burgerMuffins});
        console.log("data view:", this.state.viewModel.meats[0].name)
        console.log("data:", data);
    }
}