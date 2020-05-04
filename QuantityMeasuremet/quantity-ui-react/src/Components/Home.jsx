import React, { Component } from 'react';
import Convert from '../Services/ServiceController';

export default class Home extends Component
{
    constructor(props) 
    { 
        super(props); 
        this.state={ 
            quantity:'',
            inputUnit:'',
            outputUnit:'',
            valueToConvert:'',
            convertedValue:''
         }; 
    } 
    HandleQuantityChange=(event)=>{
        console.log(event.target.value)
        var newquantity = event.target.value;
        this.setState({
            newquantity:newquantity
        })
    }
    HandleInputUnitChange=(event)=>{
        console.log(event.target.value)
        var inputUnit = event.target.value;
        this.setState({
            inputUnit:inputUnit
        })
    }
    HandleOutputUnitChange=(event)=>{
        console.log(event.target.value)
        var outputUnit = event.target.value;
        this.setState({
            outputUnit:outputUnit
        })
    } 
    HandleInputValueChange=(event)=>{
        console.log(event.target.value)
        var valueToConvert = event.target.value;
        this.setState({
            valueToConvert:valueToConvert
        })
    }
    onSubmit=(e)=>{
        e.preventDefault();
        console.log(this.state);
        var data={
            valuetoconvert:this.state.valueToConvert,
            inputtype:this.state.inputUnit,
            outputtype:this.state.outputUnit
        };
        Convert(data)
        .then(Response => {
            console.log("converteddata",Response);
            if(Response) {
                this.setState({convertedValue:Response.data});
                console.log(Response.data);
                console.log("success");
            }
            else
            {
                console.log("failure");
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
                            <option value=''>Select-Quantity</option>
                            <option value='Length'>Length</option>
                            <option value='Weight'>Weight</option>
                            <option value='Temperature'>Temperature</option>
                        </select> 
                    </div> 
                    <div className="input-unit">
                        <select className='input-select' onChange={this.HandleInputUnitChange}> 
                            <option value=''>Select-Unit</option>
                            <option value='Feet'>Feet</option> 
                            <option value='Inch'>Inch</option> 
                            <option value='Yard'>Yard</option> 
                            <option value='Celcius'>Celcius</option> 
                            <option value='Fahrenhiet'>Fahrenhiet</option> 
                            <option value='KiloGrams'>KiloGrams</option> 
                            <option value='Grams'>Grams</option> 
                        </select>
                        {/* <div className="input-select" >______</div> */}
                        <select className='input-select' onChange={this.HandleOutputUnitChange}> 
                            <option value=''>Select-Unit</option>
                            <option value='Feet'>Feet</option> 
                            <option value='Inch'>Inch</option> 
                            <option value='Yard'>Yard</option> 
                            <option value='Celcius'>Celcius</option>  
                            <option value='Fahrenhiet'>Fahrenhiet</option>  
                            <option value='KiloGrams'>KiloGrams</option> 
                            <option value='Grams'>Grams</option> 
                        </select> 
                    </div> 
                        <div className="inputs-layout-out">
                            <input type="number" className="inner-input-div" placeholder="input value" onChange={this.HandleInputValueChange} />
                           
                            <input type="number" className="inner-input-div" placeholder="converted value" defaultValue={this.state.convertedValue } />
                        </div>
                        <div className="app-button">
                            <button className="submit" onClick={this.onSubmit}>Convert</button>
                        </div>
                    </div>
               </div>
        )
    }//onChange={this.HandleInputUnitChange}
}