import React, { useState, useEffect } from "react";
import propTypes from "prop-types";
import { useSelector, useDispatch } from "react-redux";
import { getSingleBlog } from "../../actions/blogActions";
import ReactQuill from "react-quill";
import "react-quill/dist/quill.snow.css";
import Printer from "./Printer";
import { Col, Row } from "reactstrap";
import "../../styles/components/blog.scss";

const SingleLayout = ({ markup, creating, editing }) => {
  const [liked, setLiked] = useState(false);
  const [title, setTitle] = useState("");
  const [editingTitle, setEditingTitle] = useState(false);
  const [value, setValue] = useState("");
  const [showingEditor, setShowingEditor] = useState(true)

  const blog = useSelector(state => state.blogs.single);

  const like_or_dislike = () => {
    setLiked(prev => !prev);
  };
  const dispatch = useDispatch();
  useEffect(() => {
    dispatch(getSingleBlog(1));
  }, [dispatch]);
  const viewing = !creating && !editing ? true : false;

  SingleLayout.propTypes = {
    creating: propTypes.bool,
    editing: propTypes.bool,
    markup: propTypes.string
  };
  return (
    <div>
      <div className="m-auto wrapper">
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
               { !viewing && title && value && value !== "<p><br></p>" ? <button>
                  <span>{ creating ? 'Create Blog' : 'Save Blog' }</span>
                </button> : '' }
              </div>
            </section>
            </Col>
            <Col className="d-flex justify-content-center">
            {viewing ? (
              <h1>{blog.title}</h1>
            ) : (
              <div className="mt-4 ml-5">
                {!editingTitle ? (
                  <h1
                    className="h1"
                    style={{width: '400px'}}
                    onClick={() => setEditingTitle(!editingTitle)}
                  >
                    {title ? title : "Untitled Blog"}
                  </h1>
                ) : (
                  <form onSubmit={() => setEditingTitle(!editingTitle)}>
                    <input
                      style={{color: 'black', width: '400px'}}
                      onKeyPress={(e) => {
                        if(e.which === 13) setEditingTitle(!editingTitle)
                      }}
                      className="h1 text-black input--text d-block"
                      type="text"
                      value={title}
                      onChange={e => setTitle(e.target.value)}
                      placeholder="Untitled Blog"
                      autoFocus
                    />
                  </form>
                )}
              </div>
            )}
          </Col>
          <div>
            {viewing ? (
              <>
                <h1>My Content</h1>
                <p>
                  Lorem ipsum dolor sit amet consectetur adipisicing elit.
                  Quidem expedita ipsum nobis, fuga quasi debitis obcaecati
                  quisquam labore assumenda consequatur amet quae quos!
                  Similique ducimus quia, dolorem dolore aperiam ullam?
                </p>
              </>
            ) : (
              <div>
              <button onClick={() => setShowingEditor(!showingEditor)} className="button mt-3 mb-3">{showingEditor ? 'Hide Editor' : 'Show Editor'}</button>
              <ReactQuill className={!showingEditor ? 'd-none' : ''} theme="snow" value={value} onChange={setValue} />
              </div>
            )}
          </div>
        </Row>
      </div>
      <div>
        <Printer html={value} />
      </div>
    </div>
  );
};

export default SingleLayout;
