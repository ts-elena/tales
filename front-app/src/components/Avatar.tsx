import React, { useState } from "react";

interface Avatar {
  image: string;
}
const CharacterLine: React.FC<Avatar> = props => {
  return (
    <div className="avatar">
      <img src={props.image} alt="avatar" />
    </div>
  );
};

export default CharacterLine;
