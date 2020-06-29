import React from "react";
import { ILineElement } from "./../Interfaces/ILineElement";

const LineElement: React.FC<ILineElement> = (props) => {
  return (
    <span className="word-with-hint">
      <span>{props.word}</span>
    </span>
  );
};

export default LineElement;
