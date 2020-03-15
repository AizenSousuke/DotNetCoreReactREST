import React, { useState } from "react";
import { useDispatch } from 'react-redux'
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
import { setModal } from "../../actions/modal";
const Navigation = () => {
  const [isOpen, setIsOpen] = useState(false);
  const dispatch = useDispatch()

  const toggle = () => setIsOpen(!isOpen);
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
          <span
            onClick={() => dispatch(setModal('login'))}
            className="navbar__cta"
          >
            Log in
          </span>
          <span
            onClick={() => dispatch(setModal('register'))}
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
