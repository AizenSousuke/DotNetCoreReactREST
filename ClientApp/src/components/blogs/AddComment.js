import React, { useState } from "react";
import { useDispatch, useSelector } from "react-redux";
import {
  Container,
  Row,
  Col,
  Button,
  Modal,
  ModalHeader,
  ModalBody,
  ModalFooter,
  // Textarea,
} from "reactstrap";
import { createComment } from "../../actions/blogActions";
import "../../styles/components/addcomment.scss";
// import CommonModal from "../common/CommonModal";
// import CommentForm from "./CommentForm";

const AddComment = (props) => {
  const dispatch = useDispatch();
  // const user = useSelector(state => state.auth.user);
  const [modal, setModal] = useState(false);
  const [content, setContent] = useState("");
  const toggle = () => setModal(!modal);

  return (
    <Container>
      <Button className="comment-modal-btn" onClick={toggle}>
        Comment
      </Button>
      <Modal
        isOpen={modal}
        fade={true}
        toggle={toggle}
        className="comments-modal"
      >
        <ModalHeader className="comment-modal-header" toggle={toggle}>
          Leave a comment
          {
            // make user-specific
            <Row>
              <Col sm="4">
                <img
                  src="https://www.w3schools.com/howto/img_avatar.png"
                  alt="avatar"
                />
              </Col>
            </Row>
          }
        </ModalHeader>
        <ModalBody className="comment-modal">
          <textarea
            form="comment-box"
            onChange={(e) => setContent(e.target.value)}
            // responsive?
            rows={8}
            cols={60}
          />
          <form
            id="comment-form"
            onSubmit={(e) => {
              e.preventDefault();

              // console.log("content: ", content);
              dispatch(
                createComment(
                  content,
                  props.postId,
                  props.applicationUserId,
                  false
                  // moment().format("DD-MM-YYYY"),
                )
              );
            }}
          >
            <Button type="submit" color="primary" onClick={toggle}>
              Send
            </Button>
          </form>
        </ModalBody>
        <ModalFooter></ModalFooter>
      </Modal>
    </Container>
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
