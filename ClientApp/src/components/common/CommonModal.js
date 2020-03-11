import React from "react";
import { useDispatch, useSelector } from "react-redux";
import { Button, Modal, ModalHeader, ModalBody, ModalFooter } from "reactstrap";
import { setModal } from "../../actions/auth";

const CommonModal = ({ bodyContent, buttonTitle, title, modalName, defaultButtons }) => {
  const dispatch = useDispatch();
  const getModal = useSelector(state => state.modal)
  const close = () => {
    dispatch(setModal(false));
  };
  return (
    <div>
      <Modal isOpen={getModal.type && getModal.type === modalName} toggle={() => close()}>
        <ModalHeader toggle={() => close()}>{title}</ModalHeader>
        <ModalBody>{bodyContent}</ModalBody>
        { defaultButtons && <ModalFooter>
          <Button color="primary" onClick={() => close()}>
            {buttonTitle}
          </Button>
          <Button color="secondary" onClick={() => close()}>
            Close
          </Button>
        </ModalFooter> }
      </Modal>
    </div>
  );
};

export default CommonModal;
