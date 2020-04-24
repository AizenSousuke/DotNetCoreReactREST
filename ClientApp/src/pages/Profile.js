import React from "react";
import Layout from "../components/Layout";
import ProfileInfo from "../components/profile/ProfileInfo";
import { useSelector } from "react-redux";
import BlogLayout from "../components/blogs/BlogLayout";
const Profile = () => {
    const blogs = useSelector(state => state.blogs.all)
    const fakeBlogs = blogs.slice(0, 4)
  return (
    <Layout>
        <div className="profile">
          <ProfileInfo />
          <BlogLayout blogs={fakeBlogs} />
        </div>
    </Layout>
  );
};

export default Profile;
