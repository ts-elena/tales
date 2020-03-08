import React, { useState } from "react";

const Word: React.FC<any> = props => {
  return (
    <span className="word-with-hint">
      <span>{props.word} </span>
    </span>
  );
};

export default Word;
