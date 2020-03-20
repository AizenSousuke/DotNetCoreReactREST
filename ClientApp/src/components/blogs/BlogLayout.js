import React from 'react'
import { Card, Container } from 'reactstrap';
import { NavLink } from 'react-router-dom';
const BlogLayout = ({blogs}) => {
    return (
      <div className="blogs">
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
                      backgroundPosition: "50%"
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
                          <NavLink to={`/blog/${blog.name}`} className="button button--primary">
                            View Blog
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