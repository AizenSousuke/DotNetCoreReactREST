import React, { useState, useEffect } from "react";
import { Form } from "reactstrap";
import { useDispatch, useSelector } from "react-redux";
import {
  getUsers,
  login,
  setMessage,
  setErrors,
  getLoginStatus,
} from "../../actions/auth";
import { setModal } from "../../actions/modal";

const LoginForm = () => {
  const [email, setEmail] = useState("");
  const [password, setPassword] = useState("");
  const dispatch = useDispatch();
  const errors = useSelector((state) => state.auth.errors);
  const user = useSelector((state) => state.auth.user);
  const users = useSelector((state) => state.auth.users);
  console.log("seluser", users.data);

  useEffect(() => {
    dispatch(getUsers());
    dispatch(setModal(false));
  }, [dispatch, user]);

  const loginUser = () => {
    dispatch(setMessage(""));
    dispatch(setErrors(null));
    const userObj = {
      email,
      password,
    };
    dispatch(login(users, userObj));
    // dispatch(getLoginStatus());
  };

  return (
    <Form
      onSubmit={(e) => {
        e.preventDefault();
        loginUser();
      }}
      className="login-form"
    >
      {errors && errors.credentials ? (
        <p className="text-danger text-center">{errors.credentials.message}</p>
      ) : (
        ""
      )}
      <div>
        <input
          type="email"
          className="default-input"
          name="email"
          placeholder="E-mail"
          value={email}
          onChange={(e) => setEmail(e.target.value)}
        />
      </div>
      <div>
        <input
          type="password"
          className="default-input"
          name="password"
          placeholder="Password"
          value={password}
          onChange={(e) => setPassword(e.target.value)}
        />
      </div>
      <div className="text-center">
        <button className="button button--primary">Login</button>
      </div>
    </Form>
  );
};

export default LoginForm;
