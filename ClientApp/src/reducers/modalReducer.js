export function modalReducer(state = {}, { type, payload }) {
  switch (type) {
    case "SET_MODAL":
      return {
        ...state,
        type: payload
      };
    default:
      return state;
  }
}
