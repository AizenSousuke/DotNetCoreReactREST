import React, { useState } from "react";
import { useDispatch, useSelector } from "react-redux";
import { CSSTransition } from "react-transition-group";
import { setModal } from "../../actions/modal";
import { NavLink } from "react-router-dom";
import {
  Collapse,
  Navbar,
  NavbarToggler,
  NavbarBrand,
  Nav,
  NavItem,
  Container
} from "reactstrap";
import Register from "../auth/Register";
import Login from "../auth/Login";
import SmallPanel from "../common/SmallPanel";
const Navigation = () => {
  const [isOpen, setIsOpen] = useState(false);
  const [panelOpen, setPanelOpen] = useState(false);
  const dispatch = useDispatch();
  const toggle = () => setIsOpen(!isOpen);
  const togglePanel = () => setPanelOpen(!panelOpen);
  const user = useSelector(state => state.auth.user);
  const authCheck = () => {
    if (!user) {
      return (
        <>
          <span
            onClick={() => dispatch(setModal("login"))}
            className="navbar__cta"
          >
            Log in
          </span>
          <span
            onClick={() => dispatch(setModal("register"))}
            className="navbar__cta"
          >
            Sign up
          </span>
        </>
      );
    } else {
      return (
        <>
          <span
            onClick={() => dispatch(setModal("login"))}
            className="navbar__cta"
          >
            Write a blog
          </span>
          <NavLink to="/browse">My blogs</NavLink>
          <div className="navbar__avatar">
            <img
              onClick={() => togglePanel()}
              src="https://www.w3schools.com/howto/img_avatar.png"
              alt="avatar"
            />
            <div className="panel">
              {panelOpen ? (
                <i
                  onClick={() => togglePanel()}
                  className="fas fa-angle-up"
                ></i>
              ) : (
                <i
                  onClick={() => togglePanel()}
                  className="fas fa-angle-down"
                ></i>
              )}
            </div>
            
          </div>
              <CSSTransition unmountOnExit appear in={panelOpen} timeout={100} classNames="fade">
                <SmallPanel closePanel={togglePanel} />
              </CSSTransition>
        </>
      );
    }
  };
  return (
    <Container>
      <Register />
      <Login />
      <Navbar color="light" light expand="md">
        <NavbarBrand>Blog App</NavbarBrand>
        <NavbarToggler onClick={toggle} />
        <Collapse isOpen={isOpen} navbar>
          <Nav className="mr-auto" navbar>
            <NavItem>
              <NavLink activeClassName="active" to="/">
                Home
              </NavLink>
            </NavItem>
            <NavItem>
              <NavLink to="/browse">Browse</NavLink>
            </NavItem>
          </Nav>
          {authCheck()}
        </Collapse>
      </Navbar>
    </Container>
  );
};

export default Navigation;
