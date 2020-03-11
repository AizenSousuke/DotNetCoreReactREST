import axios from "axios"

export const getBlogs = () => async dispatch => {
    const response = await axios.get(
      "https://jsonplaceholder.typicode.com/posts"
    );
    dispatch({type: "SET_BLOGS", payload: response.data})
}