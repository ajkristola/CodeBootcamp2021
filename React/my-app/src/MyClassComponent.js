// Create a new class component that supports react's lifecycle of components
// Implemement the following:

// - a constructor to your component
// - a render method = ReactDOM.render(element, document.getElementById('root'));
// - a componentDidMount() method

import React from 'react';

class MyClassComponent extends React.Component {
    render() {
        return <h1>Hello from a Javascript class!</h1>;
    }
}

export default MyClassComponent;