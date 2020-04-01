import React from 'react'


import Layout from "../components/Layout";

import SingleLayout from '../components/blogs/SingleLayout';

const Blog = props => {

    return (
      <Layout>
        <SingleLayout creating={true} />
      </Layout>
    );
}

export default Blog