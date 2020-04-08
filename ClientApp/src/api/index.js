import axios from 'axios'

const api = axios.create({
  baseURL: "https://localhost:5001/api",
  headers: {
    //   'Content-Type': 'application/json',
      Accept: 'application/json'
  }
});
export default api;