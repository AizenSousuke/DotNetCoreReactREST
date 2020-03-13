import React from "react";
import { useDispatch, useSelector } from "react-redux";
import { Button, Modal, ModalBody, ModalFooter } from "reactstrap";
import { setModal } from "../../actions/auth";
// modalName is a must so that the reducer can recognize what modal to open
const CommonModal = ({ bodyContent, buttonTitle, title, modalName, defaultButtons }) => {
  const dispatch = useDispatch();
  const getModal = useSelector(state => state.modal)
  const close = () => {
    dispatch(setModal(false));
  };
  return (
    <div>
      <Modal isOpen={getModal.type && getModal.type === modalName} toggle={() => close()}>
        <h1 className="text-center mt-5">{title}</h1>
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
