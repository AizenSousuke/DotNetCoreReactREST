import React, { useState } from "react";
import { Form } from "reactstrap";

const LoginForm = () => {
  const [email, setEmail] = useState('')
  const [password, setPassword] = useState('')
  return (
    <Form className="login-form">
      <div>
      <input type="email" className="default-input" name="email" placeholder="E-mail" value={email} onChange={(e) => setEmail(e.target.value)} />
      </div>
      <div>
      <input type="password" className="default-input" name="password" placeholder="Password" value={password} onChange={(e) => setPassword(e.target.value)} />
      </div>
      <div className="text-center">
      <button className="button button--primary">Login</button>
      </div>
    </Form>
  );
};

export default LoginForm;
