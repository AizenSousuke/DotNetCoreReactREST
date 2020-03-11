import React, { useState } from "react";
import { Button, Form, FormGroup, Label, Input } from "reactstrap";

const LoginForm = () => {
  return (
    <Form>
      <FormGroup>
        <Label for="email">Email or Username</Label>
        <Input
          type="email"
          name="email"
          id="email"
          placeholder="Enter Your Email or Username"
        />
      </FormGroup>
      <FormGroup>
        <Label for="password">Password</Label>
        <Input
          type="password"
          name="password"
          id="password"
          placeholder="Enter Your Password"
        />
      </FormGroup>
      <Button>Login</Button>
    </Form>
  );
};

export default LoginForm;
