import React, { useState, useEffect } from "react";
import { useDispatch, useSelector } from "react-redux";
import { setModal } from "../../actions/modal";
import { NavLink } from "react-router-dom";
import {
  Collapse,
  Navbar,
  NavbarToggler,
  NavbarBrand,
  Nav,
  NavItem,
  Container,
} from "reactstrap";
import Register from "../auth/Register";
import Login from "../auth/Login";
import NavbarPanel from "./NavbarPanel";
import { getLoginStatus } from "../../actions/auth";
const Navigation = () => {
  const [isOpen, setIsOpen] = useState(false);
  const [isLoggedIn, setIsLoggedIn] = useState(false);
  // const [loggedIn, setLoggedIn] = useState(false);
  const dispatch = useDispatch();
  const toggle = () => setIsOpen(!isOpen);
  const user = useSelector((state) => state.auth.user);
  const loggedIn = useSelector((state) => state.auth.loggedIn);

  console.log("lin", loggedIn);
  console.log("navUser:", user);
  console.log("cookie", document.cookie);

  // useEffect(() => {
  //   dispatch(getLoginStatus());
  // });

  const authCheck = () => {
    if (!loggedIn) {
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
      return <NavbarPanel />;
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
          </Nav>
          {authCheck()}
        </Collapse>
      </Navbar>
    </Container>
  );
};

export default Navigation;
