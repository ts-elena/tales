import React from "react";
import Card from "react-bootstrap/Card";
import { Link } from "react-router-dom";

interface IStoryProps {
  id: string;
  name: string;
  image: string;
}

const StoryCover: React.FC<IStoryProps> = props => {
  return (
    <Link to={"/stories/" + props.id} style={{ textDecoration: "none" }}>
      <div className="story-cover">
        <div className="story-cover__image">
          <img src={props.image} alt="story cover" />
        </div>
        <span className="story-cover__text">{props.name}</span>
      </div>
    </Link>
  );
};

export default StoryCover;
