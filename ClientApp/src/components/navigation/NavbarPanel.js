import React, { useState } from 'react';
import { useDispatch } from 'react-redux';
import { setModal } from '../../actions/modal';
import { NavLink } from 'react-router-dom';
import { CSSTransition } from 'react-transition-group';
import SmallPanel from '../common/SmallPanel';

const NavbarPanel = () => {
      const dispatch = useDispatch();
        const [panelOpen, setPanelOpen] = useState(false);
        const togglePanel = () => setPanelOpen(!panelOpen);


    return (
      <>
        <span
          onClick={() => dispatch(setModal("login"))}
          className="navbar__cta"
        >
          Write a blog
        </span>
        <NavLink to="/browse">My blogs</NavLink>
        <div onClick={() => togglePanel()} className="navbar__avatar">
          <img
            src="https://www.w3schools.com/howto/img_avatar.png"
            alt="avatar"
          />
          <div className="panel">
            {panelOpen ? (
              <i className="fas fa-angle-up"></i>
            ) : (
              <i
                className="fas fa-angle-down"
              ></i>
            )}
          </div>
        </div>
        {/* {JSON.stringify(panelOpen)} */}
        <CSSTransition
          unmountOnExit
          appear
          in={panelOpen}
          timeout={100}
          classNames="fade"
        >
          <SmallPanel closePanel={togglePanel} />
        </CSSTransition>
      </>
    );
}

export default NavbarPanel;