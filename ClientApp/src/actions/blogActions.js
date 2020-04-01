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
