export function blogsReducer(state = [], { type, payload }) {
  switch (type) {
    case "SET_BLOGS":
      return payload;
    default:
      return state;
  }
}
