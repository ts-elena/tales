import React from "react";
import { IAvatar } from "../Interfaces/Interfaces";

const CharacterLine: React.FC<IAvatar> = props => {
  return (
    <span className="avatar">
      <img src={props.imageUri} alt="avatar" className="avatar__image" />
    </span>
  );
};

export default CharacterLine;
