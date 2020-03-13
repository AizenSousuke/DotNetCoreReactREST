import React, { useEffect } from 'react';
import { useDispatch } from 'react-redux'
import { Route } from 'react-router-dom';
import Home from './pages/Home';
import './styles/index.scss';
import "bootstrap/dist/css/bootstrap.min.css";
import { getBlogs } from './actions/blogActions';
import Profile from './pages/Profile';
import Browse from './pages/Browse';

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
      path="/browse"
      component={Browse}
      />
      <Route 
      path="/profile"
      component={Profile}
      />
    </div>
  );
}

export default App;
