import React, { useState, useEffect } from "react";
import {
  Card,
  Container,
  Button,
  ButtonGroup,
  ButtonToolbar,
  Progress
} from "reactstrap";
import { NavLink } from "react-router-dom";
import { useSelector } from "react-redux";
const BlogLayout = ({ blogs }) => {
  const categories = useSelector(state => state.blogs.categories); // pass as props?
  const [filteredBlogs, setFilteredBlogs] = useState();
  const [showFiltered, setShowFiltered] = useState(false);

  let blogCategories = [];
  // get list of categories that correspond to blogs
  for (let i = 0; i < blogs.length; i++) {
    if (!blogCategories.includes(blogs[i].categoryId)) {
      blogCategories.push(blogs[i].categoryId);
    }
  }
  const catlist = categories.filter(cat => blogCategories.includes(cat.id));

  return (
    <>
      <div className="categories-filter">
        <ButtonToolbar>
          {/* <h3 className="toolbar-header">Sort by category</h3> */}
          <ButtonGroup>
            {catlist.map(cat => {
              return (
                <Button
                  onClick={() => {
                    setFilteredBlogs(
                      [...blogs].filter(b => b.categoryId === cat.id)
                    );
                    if (!showFiltered) {
                      setShowFiltered(true);
                    }
                  }}
                >
                  {cat.name}
                </Button>
              );
            })}
          </ButtonGroup>
          {/* <Button
            onClick={() => {
              if (showFiltered) {
                setShowFiltered(false);
              }
            }}
          >
            Show All
          </Button> */}
        </ButtonToolbar>
      </div>
      <div className="blog-layout">
        {blogs.length ? (
          !showFiltered ? (
            <>
              <div className="d-flex flex-wrap justify-content-center">
                {blogs.map(blog => (
                  <div className="m-5 blog-container" key={blog.title}>
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
                          <p>{blog.content}</p>
                          <div className="d-flex justify-content-center">
                            <NavLink
                              to={`/blog/${blog.id}`}
                              className="button button--primary mr-2"
                            >
                              View Blog
                            </NavLink>
                            <NavLink
                              to={`/blog/edit/${blog.id}`}
                              className="button button--primary"
                            >
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
            <>
              <div className="d-flex flex-wrap justify-content-center">
                {filteredBlogs.map(blog => (
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
                          <p>{blog.content}</p>
                          <div className="d-flex justify-content-center">
                            <NavLink
                              to={`/blog/${blog.id}`}
                              className="button button--primary mr-2"
                            >
                              View Blog
                            </NavLink>
                            <NavLink
                              to={`/blog/edit/${blog.id}`}
                              className="button button--primary"
                            >
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
          )
        ) : (
          <div className="loading">
            {/* <Progress /> */}
            <h1 className="text-center">Getting Blogs...</h1>
          </div>
        )}
      </div>
    </>
  );
};

export default BlogLayout;
