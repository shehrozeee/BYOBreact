import React, { Component } from 'react';
import Form from 'react-bootstrap/Form';
import Button from 'react-bootstrap/Button';
import 'bootstrap/dist/css/bootstrap.min.css';

export class BYOB extends Component {
    static displayName = BYOB.name;

    handleChange= (event) => {
        event.preventDefault();
       /* this.setState({ BurgerName: event.target.value });
        console.log("GOT VALUE: " , event.target.value);
        console.log("updatd", this.state.BurgerName);*/
        
        this.setState({ BurgerName: event.target.value });


        console.log("GOT VALUE: ", this.state.Burger.Name);
    }

    handleSubmit(event) {
        event.preventDefault();
        //alert('A name was submitted: ' + this.state.viewModel.Burger.Name);
       // alert('A name was submitted: ' + this.state.BurgerName);
        console.log("yohoo");
       
    }

    componentDidMount() {
        this.populateBurgerData();
       
        //const requestOptions = {
        //    method: 'POST',
        //    headers: {
        //        'Content-Type': 'application/json'
        //    },
        //    body: JSON.stringify({ title: 'React POST Request Example' })
            
        //   // body: JSON.stringify({ this.state.viewModel.Burger.Name: this.state.BurgerName })
        //};
        //fetch('api / Burger / CustomerBurger', requestOptions)
        //    .then(response => response.json())
        //    .then(data => this.setState({ postId: data.id }));
    }

    static renderForecastsTable(a,meats, burgerMuffins, sauces, vegetables) {  
        return (

          
            <div>   
            <Form onSubmit={this.handleSubmit}>
                <Form.Group className="mb-3" controlId="formBasicName">
                    {/*<Form.Label>Burger Name</Form.Label>*/}
                    <Form.Control onChange={this.handleChange} type="text" placeholder="Enter your Burger Name" />
                    {/*<Form.Control name={this.state.BurgerName} onChange={this.handleChange} type="text" placeholder="Enter your Burger Name" />*/}
                    {/*<Form.Control onChange={this.handleChange} type="text" placeholder="Enter your Burger Name" />*/}
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
               
            </div>

        );
    }

    constructor(props) {
        super(props)
        this.state = {
            viewModel: { meats: [], vegetables: [], sauces: [], burgerMuffins: [] },
            Burger: { Name: '', BurgerMuffinsId: 0, MeatId: 0, VegetablesId: 0, SaucesId: 0, WithCheese: false },
            BurgerName: ""
        };

        //  this.handleChange = this.handleChange.bind(this);
        // this.handleSubmit = this.handleSubmit.bind(this);
    }

    render() {
        //let contents = BYOB.renderForecastsTable(this.state.viewModel.meats, this.state.viewModel.burgerMuffins, this.state.viewModel.sauces, this.state.viewModel.vegetables);

        return (
            <div>
                <h1 id="tabelLabel" >Buld Your Own Burger</h1>
                

                <Form onSubmit={this.handleSubmit}>
                    <Form.Group className="mb-3" controlId="formBasicName">
                        {/*<Form.Label>Burger Name</Form.Label>*/}
                        <Form.Control onChange={this.handleChange} type="text" placeholder="Enter your Burger Name" />
                        {/*<Form.Control name={this.state.BurgerName} onChange={this.handleChange} type="text" placeholder="Enter your Burger Name" />*/}
                        {/*<Form.Control onChange={this.handleChange} type="text" placeholder="Enter your Burger Name" />*/}
                    </Form.Group>

                    <Form.Group className="mb-3" controlId="MeatOptions">
                        <Form.Select aria-label="Default select example">
                            <option>Select your Meat</option>
                            {
                                this.state.viewModel.meats.map(m =>
                                    <option value={m.id}>{m.name}</option>
                                )
                            }
                        </Form.Select>
                    </Form.Group>

                    <Form.Group className="mb-3" controlId="MuffinOptions">
                        <Form.Select aria-label="Default select example">
                            <option>Select your Bun</option>
                            {
                                this.state.viewModel.burgerMuffins.map(m =>
                                    <option value={m.id}>{m.name}</option>
                                )
                            }
                        </Form.Select>
                    </Form.Group>

                    <Form.Group className="mb-3" controlId="SaucesOptions">
                        <Form.Select aria-label="Default select example">
                            <option>Select your Sauce</option>
                            {
                                this.state.viewModel.sauces.map(m =>
                                    <option value={m.id}>{m.name}</option>
                                )
                            }
                        </Form.Select>
                    </Form.Group>

                    <Form.Group className="mb-3" controlId="VegetablesOptions">
                        <Form.Select aria-label="Default select example">
                            <option>Select your Vegetables</option>
                            {
                                this.state.viewModel.vegetables.map(m =>
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
                {/*<form>*/}
                {/*    <input type="text" placeholder="enter" onChange={this.handleChange}></input>*/}
                {/*</form>*/}
            </div>

        );
    }

    async populateBurgerData() {  
        const response = await fetch('api/Burger/GetBurgerItems');//6 after submit
        const data = await response.json();
        this.setState({ viewModel: data });
        //console.log("data view:", this.state.viewModel.meats[0].name)
        //console.log("data:", data);
    }
}