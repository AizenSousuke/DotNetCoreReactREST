const initialState = {
  all: [],
  loading: true,
  single: {
    id: 0,
    title: "",
    body: ""
  }
}

export function blogsReducer(state = initialState, { type, payload }) {
  switch (type) {
    case "SET_BLOGS":
      return {
        ...state,
        all: payload,
        loading: false
      }
    case "SET_SINGLE_BLOG":
      return {
        ...state,
        loading: false,
        single: payload
      }
    default:
      return state;
  }
}
