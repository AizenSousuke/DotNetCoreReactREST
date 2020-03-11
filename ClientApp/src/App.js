import React, { useEffect } from 'react';
import { useDispatch } from 'react-redux'
import { Route } from 'react-router-dom';
import Home from './pages/Home';
import './styles/index.scss';
import "bootstrap/dist/css/bootstrap.min.css";
import { getBlogs } from './actions/blogActions';
import Profile from './pages/Profile';

const App = () => {
  const dispatch = useDispatch()
  useEffect(() => {
    dispatch(getBlogs())
  })
  return (
    <div className="app">
      <Route 
      exact
      path="/"
      component={Home}
      />
      <Route 
      path="/profile"
      component={Profile}
      />
    </div>
  );
}

export default App;
