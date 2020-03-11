import React, { useState } from "react";
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
const Navigation = () => {
  const [isOpen, setIsOpen] = useState(false);
  const [loginModal, setLoginModal] = useState(false);
  const [registerModal, setRegisterModal] = useState(false);

  const toggle = () => setIsOpen(!isOpen);
  return (
    <Container>
      {registerModal && <Register />}
      {loginModal && <Login />}
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
          <span
            onClick={() => setLoginModal(!loginModal)}
            className="navbar__cta"
          >
            Log in
          </span>
          <span
            onClick={() => setRegisterModal(!registerModal)}
            className="navbar__cta"
          >
            Sign up
          </span>
        </Collapse>
      </Navbar>
    </Container>
  );
};

export default Navigation;
