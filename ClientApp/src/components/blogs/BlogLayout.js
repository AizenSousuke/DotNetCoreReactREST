import React from 'react'
import { Card, Container } from 'reactstrap';
import { NavLink } from 'react-router-dom';
const BlogLayout = ({blogs}) => {
    return (
      <div className="blog-layout">
        {blogs.length ? (
          <>
            <div className="d-flex flex-wrap justify-content-center">
              {blogs.map(blog => (
                <div className="m-5" key={blog.title}>
                  <h3>{blog.title}</h3>
                  <Card
                    style={{
                      backgroundImage:
                        "url(https://i.picsum.photos/id/1025/4951/3301.jpg)",
                      backgroundSize: "cover",
                      backgroundPosition: "50%"
                    }}
                    className="m-0"
                  >
                    <div className="card-overlay text-center ">
                      <Container className="mt-3">
                        <p>
                          {blog.content}
                        </p>
                        <div className="d-flex justify-content-center">
                          <NavLink to={`/blog/${blog.id}`} className="button button--primary mr-2">
                            View Blog
                          </NavLink>
                          <NavLink to={`/blog/edit/${blog.id}`} className="button button--primary">
                            Edit
                          </NavLink>
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
    );
}

export default BlogLayout;