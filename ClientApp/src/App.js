import React, { useEffect } from "react";
<<<<<<< HEAD
import { useDispatch } from "react-redux";
import { Route } from "react-router-dom";
import "./styles/index.scss";
import "bootstrap/dist/css/bootstrap.min.css";
import { getBlogs, setDummyComments } from "./actions/blogActions";
=======
import { useDispatch, useSelector } from "react-redux";
import { Route } from "react-router-dom";
import "./styles/index.scss";
import "bootstrap/dist/css/bootstrap.min.css";
import { getBlogs, getUsers, getCategories } from "./actions/blogActions";
>>>>>>> testing/real-data
import { setUser } from "./actions/auth";
import Profile from "./pages/Profile";
import Browse from "./pages/Browse";
import Blog from "./pages/Blog";

const App = () => {
  const dispatch = useDispatch();
  useEffect(() => {
    dispatch(getBlogs());
<<<<<<< HEAD
=======
    dispatch(getUsers());
    dispatch(getCategories());
>>>>>>> testing/real-data
    const user = JSON.parse(localStorage.getItem("user"));
    if (user) {
      dispatch(setUser(user));
    }
  });
<<<<<<< HEAD

  for (let i = 0; i < 10; i++) {
    dispatch(setDummyComments(i));
  }

=======
>>>>>>> testing/real-data
  return (
    <div className="app">
      <Route exact path="/" component={Browse} />
      {/* <Route 
      path="/browse"
      component={Browse}
      /> */}
      <Route path="/profile" component={Profile} />
      <Route path="/blog/:id" component={Blog} exact />
      <Route path="/blog/:action/:id" component={Blog} exact />
      <Route path="/create/" component={Blog} />
    </div>
  );
};

export default App;
