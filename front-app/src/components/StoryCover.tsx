import React from "react";
import { Link } from "react-router-dom";
import { IStoryProps } from "../Interfaces/IStoryProps";

const StoryCover: React.FC<IStoryProps> = (props) => {
  return (
    <Link to={"/stories/" + props.id} className="link">
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
