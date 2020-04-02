import axios from 'axios'

axios.create({
  baseURL: "https://localhost:5001/api",
  headers: {
      'ContentType': 'application/json',
      Accept: 'application/json'
  }
});