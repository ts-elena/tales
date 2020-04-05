import React, { useState } from "react";
import { IAvatar } from "./../Utils/Interfaces";

const CharacterLine: React.FC<IAvatar> = props => {
  return (
    <span className="avatar">
      <img src={props.image} alt="avatar" className="avatar__image" />
    </span>
  );
};

export default CharacterLine;
