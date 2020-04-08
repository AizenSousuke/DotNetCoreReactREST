import api from "../api";

export const getBlogs = () => async dispatch => {
  const response = await api.get("/posts");
  dispatch({ type: "SET_BLOGS", payload: response.data });
};

export const getSingleBlog = id => async (dispatch, getState) => {
  dispatch({ type: "SET_BLOG_LOADING", payload: true });
  if (!id) {
    dispatch({ type: "SET_SINGLE_BLOG", payload: null });
    return;
  }
  const blogs = getState().blogs.all;
  const blog = blogs.find(b => b.id === id);
  if (blog) {
    dispatch({ type: "SET_SINGLE_BLOG", payload: blog });
    return;
  }
  const response = await api.get(`/posts/${id}`);
  console.log(response);
  dispatch({ type: "SET_SINGLE_BLOG", payload: response.data });
};

export const editBlog = blog => async dispatch => {
  console.log(blog);
  await api.patch("/posts/" + blog.id, [
    {
      value: blog.title,
      path: "/title",
      op: "replace"
    },
    {
      value: blog.description,
      path: "/content",
      op: "replace"
    },
    {
      path: "/categoryId",
      value: blog.categoryId,
      op: "replace"
    }
  ]);
  dispatch({ type: "UPDATE_BLOG", payload: blog });
};
