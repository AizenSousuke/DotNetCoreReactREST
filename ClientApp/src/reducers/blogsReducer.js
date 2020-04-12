const initialState = {
  all: [],
  loading: true,
  single: {
    id: 0,
    title: "",
    body: "",
    comments: []
  },
  comments: []
};

export function blogsReducer(state = initialState, { type, payload }) {
  switch (type) {
    case "SET_BLOGS":
      return {
        ...state,
        all: payload,
        loading: false
      };
    case "SET_SINGLE_BLOG":
      return {
        ...state,
        loading: false,
        single: payload
      };
    case "SET_BLOG_LOADING":
      return {
        ...state,
        loading: payload
      };
    case "CREATE_COMMENT":
      return {
        ...state,
        loading: false,
        comments: [...state, payload]
        // single: { ...state.single, comments: payload }
      };
    case "SET_DUMMY_COMMENTS":
      return {
        ...state,
        comments: [...state.comments, payload]
      };
    default:
      return state;
  }
}
