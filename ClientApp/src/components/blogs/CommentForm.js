import React, { useState, useEffect } from "react";
import { Form } from "reactstrap";
import { useDispatch, useSelector } from "react-redux";
import { setModal } from "../../actions/modal";

const CommentForm = props => {
  const [content, setContent] = useState("");
  const dispatch = useDispatch();
  useEffect(() => {
    dispatch(setModal(false));
  });

  return (
    <Form
      id="comment-form"
      onSubmit={e => {
        dispatch(props.createComment());
      }}
    >
      <div className="message-box">
        <textarea
          form="comment-form"
          value={content}
          placeholder="Your comment"
        />
      </div>
      <div className="text-center">
        <button className="button button--primary">Send</button>
      </div>
    </Form>
  );
};
export default CommentForm;
