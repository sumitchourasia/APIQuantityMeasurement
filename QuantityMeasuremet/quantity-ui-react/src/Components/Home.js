import React, { Component } from 'react'

export default class Home extends Component
{
    constructor(){
        super();
        this.state={
            quantity,
            inputUnit,
            outputUnit,
            valueToConvert
        }
    }

    HandleQuantityChange=(event)=>{
        var quantity = event.target.value;
        this.setState({
            quantity=quantity
        })
    }

    HandleInputUnitChange=(event)=>{
        var inputUnit = event.target.value;
        this.setState({
            inputUnit=inputUnit
        })
    }

    HandleOutputUnitChange=(event)=>{
        var outputUnit = event.target.value;
        this.setState({
            outputUnit=outputUnit
        })
    }

    componentDidMount=()=>{
        Convert()
        .then(Response => {
         console.log("data converted")
            if(Response) {
                this.setState({convertedValue:Response.data});
                console.log(Response.data);
                console.log("success");
            }
        });
    }

    render() {
        return (

            <div className="main-div"> 
            <div className="header-div">Quantity Measurement</div>
            <div className="main-test-div">
                <div className="Quantity-div">
                    <select className='select-div' onChange={this.HandleQuantityChange}>
                        <option value='Length'>Length</option>
                        <option value='Weight'>Weight</option>
                        <option value='Temperature'>Temperature</option>
                    </select> 
                </div> 
                    <select className='input-select' onChange={this.HandleInputUnitChange}>
                        <option value='Feet'>Feet</option>
                        <option value='Inch'>Inch</option>
                        <option value='Yard'>Yard</option>
                        <option value='Celcius'>Celcius</option>
                        <option value='Fahrenhiet'>Fahrenhiet</option>
                        <option value='KiloGrams'>KiloGrams</option>
                        <option value='Grams'>Grams</option>
                    </select>
                    <div className="input-select" >______</div>
                    <select className='input-select' onChange={this.HandleOutputUnitChange}>
                    <option value='Feet'>Feet</option>
                        <option value='Inch'>Inch</option>
                        <option value='Yard'>Yard</option>
                        <option value='Celcius'>Celcius</option>
                        <option value='Fahrenhiet'>Fahrenhiet</option>
                        <option value='KiloGrams'>KiloGrams</option>
                        <option value='Grams'>Grams</option>
                    </select> 
                    <div className="inputs-layout-out">
                        <input type="number" className="inner-input-div" onChange={this.HandleInputUnitChange} />
                    <div className="input-select">=</div>
                        <input type="number" className="inner-input-div" value={this.state.outputValue } onChange={this.HandleInputUnitChange}/>
                    </div>
        </div>
        </div>
        )
    }
}