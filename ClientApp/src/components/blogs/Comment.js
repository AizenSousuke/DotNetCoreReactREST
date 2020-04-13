import React, { useState } from "react";
import { Row, Col, Container } from "reactstrap";
import "../../styles/components/comment.scss";
import { useDispatch } from "react-redux";
import { likeComment, deleteLike } from "../../actions/blogActions";

const Comment = props => {
  const [liked, setLiked] = useState(false);
  const dispatch = useDispatch();
  return (
    <Row className="comment" key={props.id}>
      <Col xs="2">
        <img
          src="https://www.w3schools.com/howto/img_avatar.png"
          alt="avatar"
        />
      </Col>
      <Col md="9">
        <a>{!props.isAnonmyous ? props.name : null}</a>
        <div>
          <i className="far fa-clock"></i>
          <span> {props.date}</span>
        </div>
        <p>{props.content}</p>
      </Col>
      <Col xs="1">
        <div className="like-container">
          {!liked ? (
            <i
              onClick={() => {
                setLiked(true);
                // dispatch(likeComment(1, 1));
              }}
              className="far fa-lg fa-thumbs-up like-button"
            />
          ) : (
            <i
              onClick={() => {
                setLiked(false);
                // dispatch(deleteLike(1, 1));
              }}
              className="fas fa-lg fa-thumbs-up like-button"
            />
          )}
        </div>
        <button className="btn-primary">Reply</button>
      </Col>
    </Row>
  );
};

export default Comment;
