import React, { useState } from "react";
import { useDispatch, useSelector } from "react-redux";
import { Button, Modal, ModalHeader, ModalBody, ModalFooter } from "reactstrap";
import { createComment } from "../../actions/blogActions";
import "../../styles/components/addcomment.scss";
// import CommonModal from "../common/CommonModal";
// import CommentForm from "./CommentForm";
import moment from "moment";

const AddComment = props => {
  const dispatch = useDispatch();
  const user = useSelector(state => state.auth.user);
  const [modal, setModal] = useState(false);
  const [content, setContent] = useState("");
  const toggle = () => setModal(!modal);

  let id = 51;
  let name = "JB";
  return (
    <>
      <Button className="comment-modal-btn" onClick={toggle}>
        Comment
      </Button>
      <Modal
        isOpen={modal}
        fade={false}
        toggle={toggle}
        className="comments-modal"
      >
        <ModalHeader toggle={toggle}>Leave a comment</ModalHeader>
        <ModalBody className="comment-modal">
          {/* <div className="comment-box-wrapper">
            <textarea form="comment-box" onChange={setContent} />
          </div> */}
          <textarea form="comment-box" onChange={setContent} />
          <form
            id="comment-form"
            onSubmit={e => {
              e.preventDefault();
              console.log("content: ", content);
              dispatch(
                createComment(
                  id,
                  name,
                  content,
                  moment().format("DD-MM-YYYY"),
                  false
                )
              );
            }}
          />
        </ModalBody>
        <ModalFooter>
          <Button color="primary" onClick={toggle}>
            Send
          </Button>
        </ModalFooter>
      </Modal>
    </>

    // <CommonModal
    //   bodyContent={CommentForm()}
    //   buttonTitle="Send"
    //   title="Leave a comment"
    //   modalName="comment"
    //   defaultButtons={false}
    // />
  );
};

export default AddComment;
