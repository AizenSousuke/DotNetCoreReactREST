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
    case "SET_BLOG_LOADING":
      return {
        ...state,
        loading: payload,
      }
    case "UPDATE_BLOG":
      const temp = state.all.find(blog => blog.id === payload.id)
      const index = state.all.indexOf(temp)
      return {
        ...state,
        loading: false,
        all: [
          ...state.all.slice(0, index),
          { title: payload.title, content: payload.description, categoryId: payload.categoryId },
          ...state.all.slice(index + 1)
        ]
      };
    default:
      return state;
  }
}
