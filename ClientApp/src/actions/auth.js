import api from "../api";

// const users = JSON.parse(localStorage.getItem("users"));

export const login = (users, { email, password }) => async (dispatch) => {
  const invalid = {
    credentials: { message: "Invalid Credentials" },
  };
  console.log("lac users", users);

  // // get the userId, then call /api/users/{id} on refresh?
  // const currentUserId = users.data.find((user) => user.email === email);
  // console.log("current:", currentUserId.id);

  const emailExists = users.data.find((user) => user.email === email);
  console.log("exist", emailExists);

  if (emailExists) {
    const { id, userName, isAdmin } = emailExists;
    const response = await api
      .post("/users/login", {
        userName,
        email,
        passwordHash: password,
        isAdmin,
      })
      .then(({ data }) => {
        console.log("loginresp", data);

        // localStorage.setItem("currentUserId", emailExists.id);

        dispatch({
          type: "SET_USER",
          payload: { id, userName, email, password, isAdmin },
        });

        dispatch({ type: "SET_LOGIN_STATUS", payload: true });

        // dispatch({ type: "SET_LOGIN_STATUS", payload: data });
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
    dispatch({ type: "SET_USERS", payload: data });
  });
};

export const getUser = (id) => async (dispatch) => {
  const response = await api
    .get(`/users/${id}`)
    .then(({ data }) => dispatch({ type: "SET_USER", payload: data }));
};

export const setUser = (user) => {
  return {
    type: "SET_USER",
    payload: user,
  };
};

export const getLoginStatus = () => async (dispatch) => {
  const response = await api.get(`/users/login`).then(({ data }) => {
    console.log("GLSresp", data);
    if (data != "No user is logged in.") {
      dispatch({ type: "SET_LOGIN_STATUS", payload: true });
    } else {
      dispatch({ type: "SET_LOGIN_STATUS", payload: false });
    }
  });
};

export const resetLoginStatus = () => {
  return {
    type: "SET_LOGIN_STATUS",
    payload: false,
  };
};

// export const getLoginStatus = () => async (dispatch) => {
//   const response = await api.get(`/users/login`).then(({ data }) => {
//     console.log(response.data, "loginstatusresp");
//     return response.data;
//   });
// };

// export const getLoginStatus = () => {
//   const response = api.get(`/users/login`).then(({ data }) => {
//     return data;
//   });
// };
