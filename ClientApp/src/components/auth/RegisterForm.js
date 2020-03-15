import React, { useState } from "react";
import { Form } from "reactstrap";
import { useDispatch, useSelector } from "react-redux";
import { register, setMessage, setErrors } from "../../actions/auth";

const RegisterForm = () => {
  const [username, setUsername] = useState("");
  const [email, setEmail] = useState("");
  const [password, setPassword] = useState("");
  const dispatch = useDispatch();
  const errors = useSelector(state => state.auth.errors);
  const registerUser = () => {
    dispatch(setMessage(''));
    dispatch(setErrors(null));
    const userObj = {
      username,
      email,
      password
    };
    dispatch(register(userObj));
  };
  return (
    <Form
      onSubmit={e => {
        e.preventDefault();
        registerUser(e);
      }}
    >
      {errors && errors.credentials ? (
        <p className="text-danger text-center">{errors.credentials.message}</p>
      ) : (
        ""
      )}
      <div>
        <input
          type="text"
          className="default-input"
          name="username"
          placeholder="Username"
          value={username}
          onChange={e => setUsername(e.target.value)}
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
