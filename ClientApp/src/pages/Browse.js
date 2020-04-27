import React from "react";
import Layout from "../components/Layout";
import { useSelector, getState } from "react-redux";
import BlogLayout from "../components/blogs/BlogLayout";

const Browse = () => {
  const blogs = useSelector((state) => state.blogs.all);

  return (
    <Layout>
      <div className="browse mt-5">
        <BlogLayout blogs={blogs} />
      </div>
    </Layout>
  );
};

export default Browse;
