import React, { useState } from 'react';
import { Button, Form, FormGroup, Label, Input } from "reactstrap";

const RegisterForm = () => {
    return (
      <Form>
        <FormGroup>
          <Label for="username">Username</Label>
          <Input
            type="text"
            name="username"
            id="username"
            placeholder="Enter Your Username"
          />
        </FormGroup>
        <FormGroup>
          <Label for="email">Email</Label>
          <Input
            type="email"
            name="email"
            id="email"
            placeholder="Enter Your Email"
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
        <Button>Sign Up</Button>
      </Form>
    );
}

export default RegisterForm;