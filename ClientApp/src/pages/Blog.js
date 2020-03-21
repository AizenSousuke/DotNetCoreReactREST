import React, {useState, useEffect} from 'react'
import {useSelector, useDispatch} from 'react-redux'
import {Col, Row} from 'reactstrap'

import '../styles/components/blog.scss'
import Layout from "../components/Layout";
import {getSingleBlog} from '../actions/blogActions'

const Blog = props => {
    const dispatch = useDispatch();
    useEffect(() => {
        dispatch(getSingleBlog(1))
    }, [dispatch])
    const [liked, setLiked] = useState(false)
    const blog = useSelector(state => state.blogs.single)
    const like_or_dislike = () => {
        setLiked(prev => !prev)
    }

    return (
        <Layout>
            <div className="m-auto wrapper">
                <Row xs="1">
                    <Col md="12">
                        <section className="profile-card">
                            <div className="profile-card-avatar-and-info">
                                <img
                                src="https://www.w3schools.com/howto/img_avatar.png"
                                alt="avatar"
                                />
                                <div className="profile-card-info">
                                    <span>John Texas</span>
                                    <div>
                                        <span>24 blogs</span>
                                        <i
                                        className="fas fa-newspaper"
                                        ></i>
                                        <span>420 likes</span>
                                        <i
                                        className="fas fa-thumbs-up"
                                        ></i>
                                    </div>
                                </div>
                            </div>
                            <div className="profile-card-btns">
                                <button onClick={like_or_dislike}>
                                    {liked ? 'Liked' : (
                                        <>
                                        <span>Like this blog</span>
                                    <i
                                    className="fas fa-thumbs-up"
                                    ></i>
                                    </>
                                    )
                                }
                                </button>
                                <br />
                                <button>
                                    <span>View John's other blogs</span>
                                </button>
                            </div>
                        </section>
                        <h1 className="title">{blog.title}</h1>
                        <section>
                            {blog.body}
                        </section>
                        <h1 className="subtitle">My Subtitle</h1>
                        <section>
                            {blog.body}
                        </section>
                    </Col>
                </Row>
            </div>
        </Layout>
    )
}

export default Blog