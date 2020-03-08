import React, { useState } from "react";

interface Avatar {
  image: string;
}
const CharacterLine: React.FC<Avatar> = props => {
  return (
    <span className="avatar">
      <img src={props.image} alt="avatar" className="avatar__image" />
    </span>
  );
};

export default CharacterLine;
