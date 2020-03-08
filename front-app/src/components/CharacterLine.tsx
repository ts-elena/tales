import React, { useEffect, useState } from "react";
import Avatar from "./Avatar";
import Word from "./Word";

interface CharacterLine {
  lineText: string;
  imageLink: string;
}
const CharacterLine: React.FC<CharacterLine> = props => {
  const [lineWords, setLineWords] = useState([" "]);

  useEffect(() => {
    setLineWords(props.lineText.split(" "));
  }, [props.lineText]);

  return (
    <div className="character-line">
      <Avatar image={props.imageLink} />
      <span className="character-line__text">
        {lineWords.map((word: string) => {
          return <Word word={word} />;
        })}
      </span>
    </div>
  );
};

export default CharacterLine;
