import React, { Component } from 'react';
import { BrowserRouter as Router, Switch , Route } from 'react-router-dom';
import Length from './Components/Length';
import './App.css';

class App extends Component {
  render(){
    return (
      <div className="App-side">
      <Router>
        <Switch>
          <Route path='/Length' component={Length} />
        </Switch>
    </Router>
    </div>
    )
  }
}
export default App;

