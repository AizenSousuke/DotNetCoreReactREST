import api from "../api";

// const users = JSON.parse(localStorage.getItem("users"));

export const login = (users, { email, password }) => async (dispatch) => {
  const invalid = {
    credentials: { message: "Invalid Credentials" },
  };
  const emailExists = users.data.find((user) => user.email === email);
  console.log("exist", emailExists);

  if (emailExists) {
    const { userName, isAdmin } = emailExists;
    const response = await api
      .post("/users/login", {
        userName,
        email,
        passwordHash: password,
        isAdmin,
      })
      .then(({ data }) => {
        console.log("loginresp", data);
        dispatch({ type: "SET_USER", payload: data });
      })
      .catch((error) => console.log("error", error.response.data));
  } else {
    dispatch({ type: "SET_AUTH_ERRORS", payload: invalid });
  }
};

export const register = ({ username, email, password }) => {
  let type = "";
  let payload = null;
  const invalid = {
    credentials: { message: "That email already exists" },
  };
  let users = JSON.parse(localStorage.getItem("users"));
  if (users) {
    const emailExists = users.find((user) => user.email === email);
    if (emailExists) {
      type = "SET_AUTH_ERRORS";
      payload = invalid;
    } else {
      users = [...users, { username, email, password }];
      type = "ADD_USER";
      payload = {
        user: username,
        email,
        password,
        users,
      };
    }
  } else {
    users = [{ username, email, password }];
    type = "ADD_USER";
    payload = {
      user: username,
      email,
      password,
      users,
    };
  }
  return {
    type,
    payload,
  };
};

export const setErrors = (errors) => {
  return {
    type: "SET_AUTH_ERRORS",
    payload: errors,
  };
};
export const setMessage = (message) => {
  return {
    type: "SET_AUTH_MESSAGE",
    payload: message,
  };
};

export const getUsers = () => async (dispatch) => {
  const response = await api.get("/users").then(({ data }) => {
    console.log("respusers", data);
    dispatch({ type: "SET_USERS", payload: data });
  });
};

export const setUser = (user) => {
  return {
    type: "SET_USER",
    payload: user,
  };
};
