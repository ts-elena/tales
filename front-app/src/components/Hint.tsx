import React from "react";
import { IHintProps } from "../Interfaces/IHintProps";

const Hint: React.FC<IHintProps> = (props) => {
  return <div style={props.style}>{props.hintText}</div>;
};

export default Hint;
