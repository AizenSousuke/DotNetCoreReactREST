const initialState = {
  user: null,
  loggedIn: false,
  loading: false,
  errors: null,
  token: null,
  users: [],
  message: "",
};
// this users array only exists for client side testing

export const authReducer = (state = initialState, { type, payload }) => {
  switch (type) {
    case "ADD_USER":
      // temporary
      localStorage.setItem("users", JSON.stringify(payload.users));
      return {
        ...state,
        users: [...state, payload], // ?
        loading: false,
        message: "User successfully registered!",
      };
    case "SET_USER":
      // if (payload) {
      //   localStorage.setItem("user", JSON.stringify(payload));
      // } else {
      //   localStorage.removeItem("user");
      // }
      return {
        ...state,
        user: payload,
        loading: false,
      };
    case "SET_USERS":
      return {
        ...state,
        users: payload,
        loading: false,
      };
    // case "SET_LOGIN_STATUS":
    //   if (payload != "No user is logged in.") {
    //     console.log("statusred");
    //     return {
    //       ...state,
    //       loggedIn: true,
    //     };
    //   } else {
    //     return {
    //       ...state,
    //       loggedIn: false,
    //     };
    //   }
    case "SET_LOGIN_STATUS":
      return {
        ...state,
        loggedIn: payload,
      };
    case "SET_AUTH_ERRORS":
      return {
        ...state,
        errors: payload,
      };
    case "SET_AUTH_MESSAGE":
      return {
        ...state,
        message: payload,
      };
    case "SET_AUTH_LOADING":
      return {
        ...state,
        loading: payload,
      };
    default:
      return state;
  }
};
