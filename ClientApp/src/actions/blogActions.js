import axios from "axios"

export const getBlogs = () => async dispatch => {
    const response = await axios.get(
      "https://jsonplaceholder.typicode.com/posts"
    );
    response.data.forEach((blog, i) => blog.name = `My Blog ${i+1}`)
    dispatch({type: "SET_BLOGS", payload: response.data})
}