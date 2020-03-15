import React, { useEffect, useState } from "react";
import { getTranslation } from "./../Utils/WebRequests";

interface IHintProps {
  textToTranslate: string;
  style: object;
  className: string;
}
const Hint: React.FC<IHintProps> = props => {
  const [translation, setTranslation] = useState<string>("");
  useEffect(() => {
    getTranslation(props.textToTranslate).then(data => setTranslation(data[0]));
  });
  return <div style={props.style}>{translation}</div>;
};

export default Hint;
