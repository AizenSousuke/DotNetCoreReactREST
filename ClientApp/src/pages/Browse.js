import React from "react";
import Layout from "../components/Layout";
import { useSelector } from "react-redux";
import { Card, Container } from "reactstrap";

const Browse = () => {
  const blogs = useSelector(state => state.blogs.all);

  return (
    <Layout>
      <div className="browse mt-4">
        {blogs.length ? (
          <>
            <div className="d-flex flex-wrap justify-content-center">
              {blogs.map(blog => (
                <Card
                  key={blog.title}
                  className="mb-3"
                  style={{
                    backgroundImage:
                      "url(https://picsum.photos/seed/picsum/200/300)",
                    backgroundSize: "cover"
                  }}
                >
                  <div className="card-overlay">
                    <Container>
                    <h3 className="text-center">{blog.name}</h3>
                    <p>{blog.title} Lorem ipsum dolor, sit amet consectetur adipisicing elit. Incidunt voluptas quas blanditiis ea voluptate possimus similique quos commodi delectus nobis.</p>
                    <div className="text-center d-flex justify-content-center">
                      <div className="button button--primary">View Blog</div>
                    </div>
                    </Container>
                  </div>
                </Card>
              ))}
            </div>
          </>
        ) : (
          <h1 className="text-center">Getting Blogs...</h1>
        )}
      </div>
    </Layout>
  );
};

export default Browse;
