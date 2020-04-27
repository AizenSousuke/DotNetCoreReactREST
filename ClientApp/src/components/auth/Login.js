import React from "react";
import CommonModal from "../common/CommonModal";
import LoginForm from "./LoginForm";

const Login = () => {
  return (
    <CommonModal
      bodyContent={LoginForm()}
      buttonTitle="Login"
      title="Login"
      modalName="login"
      defaultButtons={false}
    />
  );
};

export default Login;
