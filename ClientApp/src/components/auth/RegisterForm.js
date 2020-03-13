import React, { useState } from "react";
import { Form } from "reactstrap";

const RegisterForm = () => {
  const [userName, setUserName] = useState("");
  const [email, setEmail] = useState("");
  const [password, setPassword] = useState("");
  return (
    <Form>
      <div>
        <input
          type="text"
          className="default-input"
          name="username"
          placeholder="Username"
          value={userName}
          onChange={e => setUserName(e.target.value)}
        />
        <input
          type="email"
          className="default-input"
          name="email"
          placeholder="E-mail"
          value={email}
          onChange={e => setEmail(e.target.value)}
        />
      </div>
      <div>
        <input
          type="password"
          className="default-input"
          name="password"
          placeholder="Password"
          value={password}
          onChange={e => setPassword(e.target.value)}
        />
      </div>
      <div className="text-center">
        <button className="button button--primary">Sign up</button>
      </div>
    </Form>
  );
};

export default RegisterForm;
