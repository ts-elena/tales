import React, { useState, useRef } from "react";
import { getTranslation } from "./../Utils/WebRequests";
import Hint from "./Hint";
import { IAxesValues } from "../Interfaces/Interfaces";

const InteractiveLineElement: React.FC<any> = props => {
  const [isHintVisible, setIsHintVisible] = useState<boolean>(false);
  const [hintText, setHintText] = useState<string>("");
  const [test, setTest] = useState<IAxesValues>();

  const interactiveElementRef = useRef<HTMLSpanElement>(null);

  const hintStyles = {
    position: "absolute",
    right: "auto",
    left: test?.x + "px",
    top: test?.y + "px"
  } as React.CSSProperties;

  const positionHint = () => {
    const wordPosition = interactiveElementRef.current?.getBoundingClientRect();
    const axesValues = {
      x: (wordPosition?.left ? wordPosition.x : 0).toString(),
      y: (wordPosition?.top ? wordPosition.y - 30 : 0).toString()
    };
    setTest(axesValues);
  };

  let filterTimeout: NodeJS.Timeout;

  function revealHint() {
    positionHint();
    setIsHintVisible(true);
  }

  const handleMouseEnter = () => {
    if (hintText === "") {
      filterTimeout = setInterval(() => {
        getTranslation(props.word).then(data => setHintText(data[0]));
        revealHint();
        clearInterval(filterTimeout);
      }, 500);
    } else {
      revealHint();
    }
  };

  const handleMouseLeave = () => {
    clearInterval(filterTimeout);
    setIsHintVisible(false);
  };

  return (
    <span className="interactive-element">
      {isHintVisible && (
        <Hint
          className="interactive-element__hint"
          style={hintStyles}
          hintText={hintText}
        />
      )}
      <span
        className={
          isHintVisible
            ? "interactive-element__word--hover"
            : "interactive-element__word"
        }
        ref={interactiveElementRef}
        onMouseLeave={() => handleMouseLeave()}
        onMouseEnter={() => handleMouseEnter()}
      >
        {props.word}
      </span>
    </span>
  );
};

export default InteractiveLineElement;
