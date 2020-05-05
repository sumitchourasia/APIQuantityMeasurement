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
            convertedValue:'',
            quantities : ['length','weight','temperature'],
            units:['select-unit']
         }; 
    } 
    HandleQuantityChange=(event)=>{
        var newquantity = event.target.value;
        if(newquantity === 'length')
        {     console.log('inside length')
             this.setState({
            units:["Feet","Inch","Yard"]
        }, () => { console.log('callback fxn',this.state.units)  
        })}
        if(newquantity === 'weight')
        {  console.log('inside weight')
              this.setState({
            units:["Grams","KiloGrams"]
        },
        () => {console.log('callback fxn',this.state.units)
        })} 
        if(newquantity === 'temperature')
        {  console.log('inside temperature')
            this.setState({
                units:["Celcius","Fahrenheit"]
            },
              () => {console.log('callback fxn',this.state.units)
        })}
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
    handlequantity=(event)=>{
        console.log(event.target.value)
        var quantity=event.target.value;
        this.setState(
            {
                value:quantity
            }
        )
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
                        <select className='select-div' onClick={this.HandleQuantityChange}>
                            {this.state.quantities.map( quantity => (
                                <option value={quantity}>
                                    {quantity}
                                </option>
                            ))}
                        </select> 
                    </div>  
                    <div className="input-unit">
                        <select className='input-select' onClick={this.HandleInputUnitChange} >
                            {this.state.units.map( unit => (
                                <option value={unit}>
                                    {unit}
                                </option>
                            ))}
                        </select>
                        <select className='input-select' onClick={this.HandleOutputUnitChange} >
                            {this.state.units.map( unit => (
                                   <option value={unit}>
                                        {unit}
                                   </option>
                            ))}
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
    }
}