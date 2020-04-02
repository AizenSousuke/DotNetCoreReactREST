import React, { useState, useEffect } from "react";
import propTypes from "prop-types";
import { useSelector, useDispatch } from "react-redux";
 import {withRouter} from 'react-router-dom';
import { getSingleBlog } from "../../actions/blogActions";
import ReactQuill from "react-quill";
import "react-quill/dist/quill.snow.css";
import Printer from "./Printer";
import { Col, Row, Spinner } from "reactstrap";

const SingleLayout = ({ markup, match }) => {
  const [liked, setLiked] = useState(false);
  const [title, setTitle] = useState("");
  const [creating, setCreating] = useState(false)
  const [editing, setEditing] = useState(false)
  const [editingTitle, setEditingTitle] = useState(false);
  const [value, setValue] = useState("");
  const [showingEditor, setShowingEditor] = useState(true)

  const blog = useSelector(state => state.blogs.single);
  const loading = useSelector(state => state.blogs.loading);

  const like_or_dislike = () => {
    setLiked(prev => !prev);
  };
  const dispatch = useDispatch();
  useEffect(() => {
    const params = match.params
    if (!Object.keys(params).length) {
      dispatch(getSingleBlog(null));
      setCreating(true)
      return
    }
    const action = match.params.action
    if (action === 'edit') {
      dispatch(getSingleBlog(match.params.id));
      setEditing(true)
      return
    }
    dispatch(getSingleBlog(match.params.id));
  }, [dispatch, match.params]);
  const viewing = !creating && !editing ? true : false;

  SingleLayout.propTypes = {
    creating: propTypes.bool,
    editing: propTypes.bool,
    markup: propTypes.string
  };
  return (
    <div>
      {!loading ? (
        <div className="m-auto wrapper">
          <div>
            {!viewing ? (
              <div>
                <button
                  onClick={() => setShowingEditor(!showingEditor)}
                  className="button mt-3 mb-3"
                >
                  {showingEditor ? "Hide Editor" : "Show Editor"}
                </button>
                {showingEditor ? (
                  <ReactQuill
                    theme="snow"
                    value={value}
                    onChange={setValue}
                    className="mb-4"
                  />
                ) : (
                  ""
                )}
              </div>
            ) : (
              ""
            )}
          </div>
          <Row xs="1">
            <Col>
              <section className="profile-card">
                <div className="profile-card-avatar-and-info">
                  <img
                    src="https://www.w3schools.com/howto/img_avatar.png"
                    alt="avatar"
                  />
                  <div className="profile-card-info">
                    <span>John Texas</span>
                    <div>
                      <span>24 blogs</span>
                      <i className="fas fa-newspaper"></i>
                      <span>420 likes</span>
                      <i className="fas fa-thumbs-up"></i>
                    </div>
                  </div>
                </div>
                <div className="profile-card-btns">
                  <button className="d-block" onClick={like_or_dislike}>
                    {liked ? (
                      "Liked"
                    ) : (
                      <>
                        <span>Like this blog</span>
                        <i className="fas fa-thumbs-up"></i>
                      </>
                    )}
                  </button>
                  <button className="d-block">
                    <span>View John's other blogs</span>
                  </button>
                  {!viewing && title && value && value !== "<p><br></p>" ? (
                    <button>
                      <span>{creating ? "Create Blog" : "Save Blog"}</span>
                    </button>
                  ) : (
                    ""
                  )}
                </div>
              </section>

              {viewing ? (
                <div>
                  <h1>{blog && blog.title}</h1>
                  <p>
                    Lorem, ipsum dolor sit amet consectetur adipisicing elit. Ea
                    eum beatae quis est, voluptatem voluptas libero maiores quia
                    enim nihil, itaque consequuntur unde? Dolorem enim id alias
                    ea dignissimos! Neque.
                  </p>
                </div>
              ) : (
                <div>
                  {!editingTitle ? (
                    <h1
                      className={`h1 blog-creation-title ${
                        !editingTitle ? "blog-creation-editable" : ""
                      }`}
                      onClick={() => setEditingTitle(!editingTitle)}
                    >
                      <span>{title ? title : "Untitled Blog"}</span>
                    </h1>
                  ) : (
                    <form onSubmit={() => setEditingTitle(!editingTitle)}>
                      <input
                        onKeyPress={e => {
                          if (e.which === 13) setEditingTitle(!editingTitle);
                        }}
                        className="h1 text-black input--text d-block blog-creation-title"
                        type="text"
                        value={title}
                        onChange={e => setTitle(e.target.value)}
                        placeholder="Untitled Blog"
                        autoFocus
                      />
                    </form>
                  )}
                  <Printer html={value} />
                </div>
              )}
            </Col>
          </Row>
        </div>
      ) : (
        <div className="d-flex justify-content-center align-content-center h-100">
        <Spinner animation="border" role="status">
          <span className="sr-only">Loading...</span>
        </Spinner>
        </div>
      )}
    </div>
  );
};

export default withRouter(SingleLayout);