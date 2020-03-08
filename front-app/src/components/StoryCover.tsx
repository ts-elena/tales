import React from "react";
import Card from "react-bootstrap/Card";
import { Link } from "react-router-dom";

interface StoryProps {
  id: string;
  name: string;
  image: string;
}

const StoryCover: React.FC<StoryProps> = props => {
  return (
    <Link to={"/stories/" + props.id}>
      <Card className="story-card">
        <Card.Img variant="top" src={props.image} />
        <Card.Body>
          <Card.Title>{props.name}</Card.Title>
        </Card.Body>
      </Card>
    </Link>
  );
};

export default StoryCover;
