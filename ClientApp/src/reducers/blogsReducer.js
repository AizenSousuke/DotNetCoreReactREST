const initialState = {
  all: [],
  users: [],
  categories: [],
  loading: true,
  single: {
    id: 0,
    title: "",
    body: "",
    comments: [],
    likeCount: 0

    // postId and dateCreated are strings in the JSON response
  }
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
    case "UPDATE_BLOG":
      const temp = state.all.find(blog => blog.id === payload.id);
      const index = state.all.indexOf(temp);
      return {
        ...state,
        loading: false,
        all: [
          ...state.all.slice(0, index),
          {
            title: payload.title,
            content: payload.description,
            categoryId: payload.categoryId
          },
          ...state.all.slice(index + 1)
        ]
      };
    case "SET_USERS":
      return {
        ...state,
        loading: false,
        users: payload
      };
    case "SET_CATEGORIES":
      return {
        ...state,
        loading: false,
        categories: payload
      };
    case "SET_SINGLE_BLOG_COMMENTS":
      return {
        ...state,
        loading: false,
        single: { ...state.single, comments: payload }
      };
    case "SET_LIKES_FOR_COMMENT":
      return {
        ...state,
        loading: false,
        single: { ...state, comments: [...state.comments, payload] }
      };
    case "DELETE_LIKE":
      return {
        ...state,
        loading: false,
        single: { ...state, likeCount: likeCount - 1 }
      };
    case "DELETE_COMMENT":
      return {
        ...state, 
        loading: false, 
        single: { ...state, comments: } // filter / airth 
      }

    // case "TOGGLE_BLOG_LIKE":
    //   return {
    //     ...state
    //   };

    default:
      return state;
  }
}
