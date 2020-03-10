import React, { useEffect, useState } from "react";
import Avatar from "./Avatar";
import InteractiveElement from "./InteractiveLineElement";
import LineElement from "./LineElement";

interface CharacterLine {
  lineText: string;
  imageLink: string;
}
const CharacterLine: React.FC<CharacterLine> = props => {
  const [lineWords, setLineWords] = useState<JSX.Element[]>();

  function createLine() {
    let wordsSplitedBySpace = props.lineText.split(" ");

    let wordWithNoPunctuationExpression = new RegExp(/\b\w+/);
    let wordsWithPunctuationExpression = new RegExp(
      /\b\w+[!'\\#$%&'()*+,.-./:;<=>?@\\[\\\]^_‘{|}~]/
    );
    let punctuationMarks = new RegExp(/[^\w\s\n\t]/);
    let wordsWithApostrofies = new RegExp(/(?=\S*['-])([a-zA-Z'-]+)/);

    let lineElements = [];

    for (let word of wordsSplitedBySpace) {
      if (wordsWithApostrofies.test(word)) {
        lineElements.push(
          <InteractiveElement
            word={word.match(wordsWithApostrofies)?.[0] + " "}
          />
        );
        setLineWords(lineElements);
      } else if (wordsWithPunctuationExpression.test(word)) {
        lineElements.push(
          <InteractiveElement
            word={word.match(wordWithNoPunctuationExpression)?.[0]}
          />,
          <LineElement word={word.match(punctuationMarks)?.[0] + " "} />
        );
        setLineWords(lineElements);
      } else if (
        wordWithNoPunctuationExpression.test(word) &&
        !wordsWithPunctuationExpression.test(word)
      ) {
        lineElements.push(
          <InteractiveElement
            word={word.match(wordWithNoPunctuationExpression)?.[0] + " "}
          />
        );
        setLineWords(lineElements);
      }
    }
  }

  useEffect(() => {
    createLine();
  }, []);

  return (
    <div className="character-line">
      <Avatar image={props.imageLink} />
      <span className="character-line__text">{lineWords}</span>
    </div>
  );
};

export default CharacterLine;
