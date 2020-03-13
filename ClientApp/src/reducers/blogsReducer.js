const initialState = {
  all: [],
  loading: true
}

export function blogsReducer(state = initialState, { type, payload }) {
  switch (type) {
    case "SET_BLOGS":
      return {
        ...state,
        all: payload,
        loading: false
      }
    default:
      return state;
  }
}
