import axios from "axios"

export const getBlogs = () => async dispatch => {
    const response = await axios.get(
      "https://jsonplaceholder.typicode.com/posts"
    );
    response.data.forEach((blog, i) => blog.name = `My Blog ${i+1}`)
    dispatch({type: "SET_BLOGS", payload: response.data})
}

export const getSingleBlog = id => async dispatch => {
    const response = await axios.get(
      `https://jsonplaceholder.typicode.com/posts/${id}`
    );
    dispatch({type: 'SET_SINGLE_BLOG', payload: response.data})
}