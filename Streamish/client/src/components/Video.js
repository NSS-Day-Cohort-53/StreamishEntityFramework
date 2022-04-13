import React from "react";
import { Card, CardBody } from "reactstrap";
import '../index.css';

const Video = ({ video }) => {
    return (
        <Card >
            <p className="text-left px-2">Posted by: {video.userProfile.name}</p>
            <CardBody>
                <iframe className="video"
                    src={video.url}
                    title="YouTube video player"
                    frameBorder="0"
                    allow="accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture"
                    allowFullScreen />

                <p>
                    <strong>{video.title}</strong>
                </p>
                <p>{video.description}</p>
                {video.comments.map(c => <div key="{c.id}" className="comment">{c.message}</div>)}
            </CardBody>
        </Card >
    );
};

export default Video;