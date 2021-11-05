import React from 'react';
import ReactDOM from 'react-dom';
import './index.css';
import reportWebVitals from './reportWebVitals';
import LifecycleDemo from './LifecycleDemo';
import CustomerList from './CustomerList';

// this is where you place the components
ReactDOM.render(
  <React.StrictMode>
    <LifecycleDemo />
    <CustomerList />
  </React.StrictMode>,
  document.getElementById('root')
);

// If you want to start measuring performance in your app, pass a function
// to log results (for example: reportWebVitals(console.log))
// or send to an analytics endpoint. Learn more: https://bit.ly/CRA-vitals
reportWebVitals();
