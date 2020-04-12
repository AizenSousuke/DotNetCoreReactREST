import axios from "axios";

export const getBlogs = () => async dispatch => {
  const response = await axios.get(
    "https://jsonplaceholder.typicode.com/posts"
  );
  response.data.forEach((blog, i) => (blog.name = `My Blog ${i + 1}`));
  dispatch({ type: "SET_BLOGS", payload: response.data });
};

export const getSingleBlog = id => async (dispatch, getState) => {
  dispatch({ type: "SET_BLOG_LOADING", payload: true });
  if (!id) {
    dispatch({ type: "SET_SINGLE_BLOG", payload: null });
    return;
  }
  const blogs = getState().blogs.all;
  const blog = blogs.find(b => {
    if (b.id === id) return b;
  });
  if (blog) {
    dispatch({ type: "SET_SINGLE_BLOG", payload: blog });
    return;
  }
  console.log(blogs);
  const response = await axios.get(
    `https://jsonplaceholder.typicode.com/posts/${id}`
  );
  dispatch({ type: "SET_SINGLE_BLOG", payload: response.data });
};

// export const getComments = id => async dispatch => {
//   const response = await axios
//     .get("https://localhost:5001/api/comments")
//     .then(dispatch({ type: "SET_COMMENTS", payload: response.data }))
//     .catch(err => {
//       console.log;
//       "Error: ", err;
//       return null;
//     });
// };

export const createComment = (id, name, content, date, isAnonymous) => {
  return {
    type: "CREATE_COMMENT",
    payload: {
      id,
      name,
      content,
      date,
      isAnonymous
    }
  };
};

export const setDummyComments = id => {
  return {
    type: "SET_DUMMY_COMMENTS",
    payload: {
      id: id,
      name: "Lorem Ipsum",
      content:
        "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam posuere.",
      date: "Just now",
      isAnonymous: false
    }
  };
};
