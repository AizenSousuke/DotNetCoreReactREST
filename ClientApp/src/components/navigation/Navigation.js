import React, { useState } from "react";
import { NavLink } from "react-router-dom";
import {
  Collapse,
  Navbar,
  NavbarToggler,
  NavbarBrand,
  Nav,
  NavItem,
  UncontrolledDropdown,
  DropdownToggle,
  DropdownMenu,
  DropdownItem,
  NavbarText,
  Container
} from "reactstrap";
const Navigation = () => {
  const [isOpen, setIsOpen] = useState(false);

  const toggle = () => setIsOpen(!isOpen);
  return (
    <Container>
      <Navbar color="light" light expand="md">
        <NavLink to="/test">
          <NavbarBrand>Blog App</NavbarBrand>
        </NavLink>
        <NavbarToggler onClick={toggle} />
        <Collapse isOpen={isOpen} navbar>
          <Nav className="mr-auto" navbar>
            <NavItem>
                <NavLink activeClassName="active" to="/">Home</NavLink>
            </NavItem>
            <NavItem>
                <NavLink to="/browse">Browse</NavLink>
           </NavItem>
          </Nav>
          <span className="navbar__cta">
            Log in
          </span>
          <span className="navbar__cta">
            Sign up
          </span>
        </Collapse>
      </Navbar>
    </Container>
  );
};

export default Navigation;
