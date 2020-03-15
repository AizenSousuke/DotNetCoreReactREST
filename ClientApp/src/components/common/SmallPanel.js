import React from "react";
import OutsideClickHandler from "react-outside-click-handler";
import { NavLink } from "react-router-dom";
import { useDispatch } from "react-redux";
import { setUser } from '../../actions/auth'

const SmallPanel = ({ closePanel, panel }) => {
    const dispatch = useDispatch()
  return (
    <OutsideClickHandler
      onOutsideClick={() => {
        closePanel();
      }}
    >
      <div className="small-panel">
        <ul>
          <li>
            <NavLink to="/edit">Edit Account</NavLink>
          </li>
          <li onClick={() => { 
              dispatch(setUser(null)) 
              closePanel()
        }}>
            <span>Log out</span>
          </li>
        </ul>
      </div>
    </OutsideClickHandler>
  );
};

export default SmallPanel;
