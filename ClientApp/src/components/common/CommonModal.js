import React, { useState } from "react";
import { Button, Modal, ModalHeader, ModalBody, ModalFooter } from "reactstrap";

const CommonModal = ({bodyContent, buttonTitle, title, toggle, show}) => {

  return (
    <div>
      <Button color="danger" onClick={() => toggle()}>
        &times;
      </Button>
      <Modal isOpen={show} toggle={toggle}>
        <ModalHeader toggle={toggle}>{title}</ModalHeader>
        <ModalBody>
          {bodyContent}
        </ModalBody>
        <ModalFooter>
          <Button color="primary" onClick={toggle}>
            {buttonTitle}
          </Button>
          <Button color="secondary" onClick={() => toggle()}>
            Close
          </Button>
        </ModalFooter>
      </Modal>
    </div>
  );
};

export default CommonModal;
