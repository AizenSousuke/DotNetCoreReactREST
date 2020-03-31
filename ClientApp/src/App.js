import React, { useEffect } from 'react';
import { useDispatch } from 'react-redux'
import { Route } from 'react-router-dom';
import './styles/index.scss';
import "bootstrap/dist/css/bootstrap.min.css";
import { getBlogs } from './actions/blogActions';
import { setUser } from './actions/auth';
import Profile from './pages/Profile';
import Browse from './pages/Browse';
import Blog from './pages/Blog';

const App = () => {
  const dispatch = useDispatch()
  useEffect(() => {
    dispatch(getBlogs())
    const user = JSON.parse(localStorage.getItem('user'))
    if (user) {
      dispatch(setUser(user))
    }
  })
  return (
    <div className="app">
      <Route 
      exact
      path="/"
      component={Browse}
      />
      {/* <Route 
      path="/browse"
      component={Browse}
      /> */}
      <Route 
      path="/profile"
      component={Profile}
      />
      <Route 
      path="/blog/:id"
      component={Blog}
      />
    </div>
  );
}

export default App;
