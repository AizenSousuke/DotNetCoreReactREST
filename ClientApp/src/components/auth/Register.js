import React from 'react';
import CommonModal from '../common/CommonModal';
import RegisterForm from './RegisterForm';
const Register = () => {
    return (
        <CommonModal 
        bodyContent={RegisterForm()}
        buttonTitle="Sign Up"
        title="Sign Up"
        modalName="register"
        defaultButtons={false}
        />
    );
}

export default Register;