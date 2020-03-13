import React from "react";
import Layout from "../components/Layout";
import { useSelector } from "react-redux";
import { Card, Container } from "reactstrap";

const Browse = () => {
  const blogs = useSelector(state => state.blogs.all);

  return (
    <Layout>
      <div className="browse mt-5">
        {blogs.length ? (
          <>
            <div className="d-flex flex-wrap justify-content-center">
              {blogs.map(blog => (
                <div className="m-5" key={blog.title}>
                    <h3>{blog.name}</h3>
                    <Card
                        style={{
                            backgroundImage:
                                "url(https://i.picsum.photos/id/1025/4951/3301.jpg)",
                            backgroundSize: "cover",
                            backgroundPosition: "50%",
                        }}
                        className="m-0"
                    >
                        <div className="card-overlay text-center ">
                            <Container className="mt-3">
                                <p>
                                    {blog.title} Lorem ipsum dolor, sit amet consectetur
                                    adipisicing elit. Incidunt voluptas quas blanditiis ea
                                    voluptate possimus similique quos commodi delectus
                                    nobis.
                                </p>
                                <div className="d-flex justify-content-center">
                                    <div className="button button--primary">View Blog</div>
                                </div>
                            </Container>
                        </div>
                    </Card>
                </div>
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
