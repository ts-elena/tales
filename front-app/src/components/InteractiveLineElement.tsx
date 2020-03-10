import React, { useState } from "react";

const InteractiveLineElement: React.FC<any> = props => {
  const [isTranslationVisible, setIsTranslationVisible] = useState<boolean>(
    false
  );
  function handleMouseEnter() {
    setIsTranslationVisible(true);
  }
  function handleMouseLeave() {
    setIsTranslationVisible(false);
  }
  return (
    <span
      className={
        isTranslationVisible ? "interactive-word__hover" : "interactive-word"
      }
      onMouseEnter={() => handleMouseEnter()}
      onMouseLeave={() => handleMouseLeave()}
    >
      {props.word}
    </span>
  );
};

export default InteractiveLineElement;
