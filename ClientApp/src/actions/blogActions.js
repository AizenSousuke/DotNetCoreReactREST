import axios from "axios"

export const getBlogs = () => async dispatch => {
    const response = await axios.get(
      "https://localhost:5001/api/posts"
    );
    dispatch({type: "SET_BLOGS", payload: response.data})
}