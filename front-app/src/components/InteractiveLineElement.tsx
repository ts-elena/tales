import React, { useState, useRef } from "react";
import Hint from "./Hint";

const InteractiveLineElement: React.FC<any> = props => {
  const [isHintVisible, setIsHintVisible] = useState<boolean>(false);
  const [positionLeft, setPositionLeft] = useState<string>("0");
  const [positionTop, setPositionTop] = useState<string>("0");

  const interactiveElementRef = useRef<HTMLSpanElement>(null);

  const hintStyles = {
    position: "absolute",
    right: "auto",
    left: positionLeft + "px",
    top: positionTop + "px"
  } as React.CSSProperties;

  const positionHint = () => {
    const wordPosition = interactiveElementRef.current?.getBoundingClientRect();
    const width = wordPosition?.width ? wordPosition?.width / 2 : 0;
    const x = wordPosition?.left ? wordPosition.x : 0;
    const y = wordPosition?.top ? wordPosition.y - 30 : 0;
    setPositionLeft(x.toString());
    setPositionTop(y.toString());
  };

  const handleMouseEnter = () => {
    positionHint();
    setIsHintVisible(true);
  };

  const handleMouseLeave = () => {
    setIsHintVisible(false);
  };

  return (
    <span
      className="interactive-element"
      onMouseEnter={() => handleMouseEnter()}
      onMouseLeave={() => handleMouseLeave()}
    >
      {isHintVisible && (
        <Hint
          className="interactive-element__hint"
          style={hintStyles}
          textToTranslate={props.word}
        />
      )}
      <span
        className={
          isHintVisible
            ? "interactive-element__word--hover"
            : "interactive-element__word"
        }
        ref={interactiveElementRef}
      >
        {props.word}
      </span>
    </span>
  );
};

export default InteractiveLineElement;
