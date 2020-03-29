import React, { useEffect, useState, Ref, ReactNode } from "react";

interface IHintProps {
  hintText: string;
  style: object;
  className: string;
}
const Hint: React.FC<IHintProps> = props => {
  return <div style={props.style}>{props.hintText}</div>;
};

export default Hint;
