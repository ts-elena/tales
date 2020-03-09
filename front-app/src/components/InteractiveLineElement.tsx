import React from "react";

const InteractiveLineElement: React.FC<any> = props => {
  return (
    <span className="word-with-hint">
      <span>{props.word}</span>
    </span>
  );
};

export default InteractiveLineElement;
