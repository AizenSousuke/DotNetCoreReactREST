export const login = ({ email, password }) => {
  let type = "";
  let payload = null;
  const invalid = {
    credentials: {message: 'Invalid Credentials'}
  };
  const users = JSON.parse(localStorage.getItem("users"));
  const emailExists = users.find(user => user.email === email);
  if (emailExists) {
    if (password === emailExists.password) {
      type = "SET_USER";
      payload = emailExists;
    } else {
      type = "SET_AUTH_ERRORS";
      payload = invalid;
    }
  } else {
    type = "SET_AUTH_ERRORS";
    payload = invalid;
  }
  return {
    type,
    payload
  };
};

export const register = ({ username, email, password }) => {
  let type = "";
  let payload = null;
  const invalid = {
    credentials: { message: "That email already exists" }
  };
  let users = JSON.parse(localStorage.getItem("users"));
  const emailExists = users.find(user => user.email === email);
  if (emailExists) {
      type = "SET_AUTH_ERRORS";
      payload = invalid;
  } else {
      users = [...users, {username, email, password}]
    type = "ADD_USER";
    payload = {
        user: username, email, password,
        users
    };
  }
  return {
    type,
    payload
  };
};

export const setErrors = errors => {
    return {
        type: "SET_AUTH_ERRORS",
        payload: errors
    }
}
export const setMessage = message => {
    return {
        type: "SET_AUTH_MESSAGE",
        payload: message
    }
}