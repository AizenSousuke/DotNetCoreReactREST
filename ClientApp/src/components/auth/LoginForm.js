import React, { useState } from "react";
import { Form } from "reactstrap";

const LoginForm = () => {
  return (
    <Form className="login-form">
      <div>
      <input type="text" className="default-input" name="email" placeholder="E-mail" />
      </div>
      <div>
      <input type="password" className="default-input" name="password" placeholder="Password" />
      </div>
      <div className="text-center">
      <button className="button button--primary">Login</button>
      </div>
    </Form>
  );
};

export default LoginForm;
