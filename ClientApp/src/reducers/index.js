import { combineReducers } from 'redux'
import { blogsReducer } from './blogsReducer'
import { modalReducer } from './modalReducer'
import { authReducer } from './authReducer'

const allReducers = combineReducers({
    blogs: blogsReducer,
    modal: modalReducer,
    auth: authReducer
})

export default allReducers