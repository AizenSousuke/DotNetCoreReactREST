import React, { useState, useEffect } from "react";
import { Container } from "reactstrap";
import { useSelector } from "react-redux";
import OutsideClickHandler from "react-outside-click-handler";
const ProfileInfo = () => {
  const user = useSelector(state => state.auth.user);
  const [editing, setEditing] = useState(false);
  const [fake, setFake] = useState('')
  const toggleEditing = () => setEditing(!editing);
  useEffect(() => {
    if (user) {
      setFake(user.username)
    }
  }, [user])
  return (
    <Container>
      <div className="profile__info d-flex">
        <div>
          <img
            src="https://www.w3schools.com/howto/img_avatar.png"
            alt="John"
          />
        </div>
        <div className="align-self-center">
          {!editing ? (
            <h1 onClick={toggleEditing} className="ml-5">
              {user ? fake : ""}
            </h1>
          ) : (
            <form
              onSubmit={e => {
                e.preventDefault();
                toggleEditing();
              }}
            >
              <OutsideClickHandler
                onOutsideClick={() => {
                  toggleEditing();
                }}
              >
                <input
                  autoFocus
                  className="ml-5"
                  type="text"
                  value={fake}
                  onChange={e => setFake(e.target.value)}
                />
              </OutsideClickHandler>
            </form>
          )}
          <div className="ml-5">
            <span className="mr-3">24 Blogs</span>
            <span className="mr-3">400 Likes</span>
            <button onClick={toggleEditing} className="button button--primary">
              {!editing ? "Edit Profile" : "Save"}
            </button>
          </div>
        </div>
      </div>
    </Container>
  );
};

export default ProfileInfo;
