import React, { Component } from 'react';
import Form from 'react-bootstrap/Form';
import Button from 'react-bootstrap/Button';
import 'bootstrap/dist/css/bootstrap.min.css';

export class BYOB extends Component {
    static displayName = BYOB.name;

    constructor(props) {
        super(props);
        this.state = { viewModel: { meats: [], vegetables: [], sauces: [], burgerMuffins: [] } }
    }
    componentDidMount() {
        this.populateBurgerData();
    }

    static renderForecastsTable(meats, burgerMuffins, sauces, vegetables) {
        return (
            <Form>
                <Form.Group className="mb-3" controlId="formBasicName">
                    {/*<Form.Label>Burger Name</Form.Label>*/}
                    <Form.Control type="text" placeholder="Enter your Burger Name" />
                </Form.Group>

                <Form.Group className="mb-3" controlId="MeatOptions">
                    <Form.Select aria-label="Default select example">
                        <option>Select your Meat</option>
                        {
                            meats.map(m =>
                                <option value={m.id}>{m.name}</option>
                            )
                        }
                    </Form.Select>
                </Form.Group>

                <Form.Group className="mb-3" controlId="MuffinOptions">
                    <Form.Select aria-label="Default select example">
                        <option>Select your Bun</option>
                        {
                            burgerMuffins.map(m =>
                                <option value={m.id}>{m.name}</option>
                            )
                        }
                    </Form.Select>
                </Form.Group>

                <Form.Group className="mb-3" controlId="SaucesOptions">
                    <Form.Select aria-label="Default select example">
                        <option>Select your Sauce</option>
                        {
                            sauces.map(m =>
                                <option value={m.id}>{m.name}</option>
                            )
                        }
                    </Form.Select>
                </Form.Group>

                <Form.Group className="mb-3" controlId="VegetablesOptions">
                    <Form.Select aria-label="Default select example">
                        <option>Select your Vegetables</option>
                        {
                            vegetables.map(m =>
                                <option value={m.id}>{m.name}</option>
                            )
                        }
                    </Form.Select>
                </Form.Group>

                <Form.Group className="mb-3" controlId="formBasicCheckbox">
                    <Form.Check type="checkbox" label="With Cheese" />
                </Form.Group>

                <Button variant="primary" type="submit">
                    Submit
                </Button>

            </Form>

        );
    }

    render() {

        let contents = BYOB.renderForecastsTable(this.state.viewModel.meats, this.state.viewModel.burgerMuffins, this.state.viewModel.sauces, this.state.viewModel.vegetables);

        return (
            <div>
                <h1 id="tabelLabel" >Buld Your Own Burger</h1>
                {contents}
            </div>
        );
    }

    async populateBurgerData() {
        const response = await fetch('api/Burger/GetBurgerItems');
        const data = await response.json();
        this.setState({ viewModel: data });
        console.log("data view:", this.state.viewModel.meats[0].name)
        console.log("data:", data);
    }
}