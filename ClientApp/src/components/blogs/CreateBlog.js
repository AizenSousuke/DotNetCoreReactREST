import React, { useState, useRef } from "react";
import { useDispatch, useSelector } from "react-redux";
import { createBlog } from "../../actions/blogActions";
import ReactQuill, { quill } from "react-quill";
import {
  Container,
  Row,
  Col,
  Button,
  Modal,
  ModalHeader,
  ModalBody,
  ModalFooter,
  // textarea,
  Input,
  InputGroup,
  Form,
  FormGroup,
  Label,
  Dropdown,
  DropdownToggle,
  DropdownMenu,
  DropdownItem,
} from "reactstrap";
import "../../styles/components/createblog.scss";

const CreateBlog = () => {
  const [title, setTitle] = useState("");
  const [description, setDescription] = useState("");
  const [body, setBody] = useState("");
  const editorRef = useRef();
  const dispatch = useDispatch();

  const [modal, setModal] = useState(false);
  const toggleModal = () => setModal(!modal);

  const [dropdownOpen, setDropdownOpen] = useState(false);
  const toggleDropDown = () => setDropdownOpen((prevState) => !prevState);

  return (
    <div id="create-blog">
      <Button className="create-blog-modal-btn" onClick={toggleModal}>
        Create Blog
      </Button>
      <Modal
        isOpen={modal}
        fade={true}
        toggle={toggleModal}
        className="create-blog-modal"
      >
        <ModalHeader toggle={toggleModal}>Create Your Blog</ModalHeader>
        <ModalBody className="create-blog-modal">
          <Input
            type="text"
            value={title}
            onChange={(e) => {
              setTitle(e.target.value);
              console.log(title);
            }}
            placeholder="Title"
          />
          <Input
            type="text"
            value={description}
            onChange={(e) => {
              setDescription(e.target.value);
              console.log(description);
            }}
            placeholder="Description"
          />
          <Dropdown isOpen={dropdownOpen} toggle={toggleDropDown}>
            <DropdownToggle caret>Category</DropdownToggle>
            <DropdownMenu>
              <DropdownItem header>Categories</DropdownItem>
              <DropdownItem>Foo</DropdownItem>
              <DropdownItem>Bar</DropdownItem>
              <DropdownItem>Baz</DropdownItem>
            </DropdownMenu>
          </Dropdown>
          <br />
          <ReactQuill
            theme={"snow"}
            value={body}
            onChange={setBody}
            className="mb-4"
            placeholder="Body"
            // ref={editorRef}
            // modules={}
            // formats={}
          />
          <Form
            id="create-blog-form"
            onSubmit={(e) => {
              e.preventDefault();
              dispatch(createBlog(1, title, body, "1"));
            }}
          >
            <Button type="submit" color="primary" onClick={toggleModal}>
              Submit
            </Button>
          </Form>
        </ModalBody>
        <ModalFooter></ModalFooter>
      </Modal>

      {/* <input type="text" onChange={() => setValue(e.target.value)}></input> */}
    </div>
  );
};

export default CreateBlog;
