import { combineReducers } from 'redux'
import { blogsReducer } from './blogsReducer'

const allReducers = combineReducers({
    blogs: blogsReducer
})

export default allReducers