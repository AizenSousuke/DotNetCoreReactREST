const initialState = {
    user: null,
    loading: false,
    errors: null,
    token: null,
    users: [],
    message: ''
}
// this users array only exists for client side testing

export const authReducer = (state = initialState, {type, payload}) => {
    switch (type) {
        case 'ADD_USER':
            // temporary
            localStorage.setItem('users', JSON.stringify(payload.users))
            return {
                ...state,
                users: payload,
                loading: false,
                message: 'User successfully registered!'
            }
        case 'SET_USER':
            localStorage.setItem('user', JSON.stringify(payload))
            return {
                ...state,
                user: payload,
                loading: false
            }
        case 'SET_AUTH_ERRORS':
        return {
            ...state,
            errors: payload
        }
        case 'SET_AUTH_MESSAGE':
        return {
            ...state,
            message: payload
        }
        case 'SET_AUTH_LOADING': 
            return {
                ...state,
                loading: payload
            }
        default:
            return state;
    }
}