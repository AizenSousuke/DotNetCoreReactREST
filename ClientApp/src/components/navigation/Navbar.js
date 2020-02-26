import React from 'react';
import { Link } from 'react-router-dom'

const Navbar = () => {
    return (
        <div className="navbar">
            <ul>
                <li>
                    <Link style={{marginRight: '5px'}} to="/">
                        Home
                    </Link>
                    <Link to="/profile">
                        Profile
                    </Link>
                </li>
            </ul>
        </div>
    );
}

export default Navbar;