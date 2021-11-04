import React from 'react';

class LifecycleDemo extends React.Component {   // class declaration

    constructor(props) {
        super(props);
        console.log("In LifecycleDemo.constructor. Called always first, irrespective or order.");
    }
       
    render() {                                  // method for showing HTML stuff
        console.log("In LifecycleDemo.render. Called second");
        return <h1>Hello, this is the Lifecycle component!</h1>
    }

    componentDidMount() {
        console.log("In LifecycleDemo.componentDidMount. Called third.");
    }
}

export default LifecycleDemo;

