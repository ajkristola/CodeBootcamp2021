import React from 'react';

class LifecycleDemo extends React.Component {   // class declaration

    constructor(props) {
        super(props);
        console.log("In LifecycleDemo.constructor. Called always first, irrespective or order.");
        this.state = { title: "" };
    }
    
    componentDidMount() {
        fetch('https://jsonplaceholder.typicode.com/todos/1')
        .then(response => response.json())
        .then(json => {
            console.log(json.title)
            this.setState({ title: json.title });
            console.log("Component state has been modified");
        });
        console.log("Fetch call has been made.");
    }

    render() {                                  // method for showing HTML stuff
        console.log("In LifecycleDemo.render. Called second");
        return (
        <div>
            <h1>Hello, this is the Lifecycle component!</h1>
            <p>Title: {this.state.title}</p>
        </div>);
    }
}

export default LifecycleDemo;

