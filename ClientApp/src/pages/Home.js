import React from "react";
import { useSelector } from "react-redux";
import Layout from "../components/Layout";

const Home = () => {
  const blogs = useSelector(state => state.blogs);
  return (
    <Layout>
      <div className="home">Home Page</div>
      {blogs.length ? (
        <div className="text-center">
          <h1>Blogs</h1>
          {blogs.map(blog => (
            <div>
              <h3>
                {blog.title} By {blog.userId}
              </h3>
            </div>
          ))}
        </div>
      ) : (
        <h1 className="text-center">Getting Blogs...</h1>
      )}
    </Layout>
  );
};

export default Home;
