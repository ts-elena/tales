import React from "react";

const CharacterLine: React.FC<any> = (props) => {
  return (
    <span className="avatar">
      <img src={props.imageUri} alt="avatar" className="avatar__image" />
    </span>
  );
};

export default CharacterLine;
