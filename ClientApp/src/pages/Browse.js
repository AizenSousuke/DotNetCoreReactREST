import React from "react";
import Layout from "../components/Layout";
import { useSelector, getState } from "react-redux";
import BlogLayout from "../components/blogs/BlogLayout";

const Browse = () => {
  const blogs = useSelector(state => state.blogs.all);
  // const comments = useSelector(state => state.blogs.single.comments);
  // const likes = useSelector(state => state.blogs.likes);

  const dispatchAndLog = (store, action) => {
    console.log(`dispatching ${action}`);
    store.dispatch(action);
    console.log("updated state:", store.getState());
  };

  // dispatch(getSingleBlogComments(1));
  // dispatch(getLikesForComment(1));
  // console.log("singcom:", comments);
  // console.log("likk", likes);
  return (
    <Layout>
      <div className="browse mt-5">
        <BlogLayout blogs={blogs} />
      </div>
    </Layout>
  );
};

export default Browse;
