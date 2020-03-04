import React from 'react';
import axios from 'axios';

export default class TestComponent extends React.Component {

    state = {
        posts: []
    }

    componentDidMount() {
        axios.get('https://localhost:5001/api/blog').then(res => {
            const posts = res.data;
            this.setState({ posts });
        })
    }

    render() {
        return (
            <div>
                <div className="home text-center">List of Post Title:</div>
                {this.state.posts.map(posts => 
                    <>
                        <h3 className="text-center">{posts.title}</h3>
                        <p className="text-center">{posts.content}</p>
                    </>
                )}
            </div>
        );
    }
}