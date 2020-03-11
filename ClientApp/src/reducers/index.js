import { combineReducers } from 'redux'
import { blogsReducer } from './blogsReducer'
import { modalReducer } from './modalReducer'

const allReducers = combineReducers({
    blogs: blogsReducer,
    modal: modalReducer
})

export default allReducers