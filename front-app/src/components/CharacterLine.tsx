import React, { useEffect, useState } from "react";
import Avatar from "./Avatar";
import InteractiveElement from "./InteractiveLineElement";
import LineElement from "./LineElement";
import {
  wordsWithApostrofies,
  wordsWithPunctuationExpression,
  wordWithNoPunctuationExpression,
  punctuationMarks
} from "./../Utils/RegexExpressions";

interface CharacterLine {
  lineText: string;
  imageLink: string;
}
const CharacterLine: React.FC<CharacterLine> = props => {
  const [lineWords, setLineWords] = useState<JSX.Element[]>();

  function createLine() {
    let wordsSplitedBySpace = props.lineText.split(" ");
    let lineElements = [];
    let spaceElement = <span>&nbsp;</span>;

    for (let word of wordsSplitedBySpace) {
      if (wordsWithApostrofies.test(word)) {
        lineElements.push(
          <InteractiveElement word={word.match(wordsWithApostrofies)?.[0]} />,
          spaceElement
        );
        continue;
      }

      if (wordsWithPunctuationExpression.test(word)) {
        lineElements.push(
          <InteractiveElement
            word={word.match(wordWithNoPunctuationExpression)}
          />,
          <LineElement word={word.match(punctuationMarks)} />,
          spaceElement
        );
        continue;
      }

      if (
        wordWithNoPunctuationExpression.test(word) &&
        !wordsWithPunctuationExpression.test(word)
      ) {
        lineElements.push(
          <InteractiveElement
            word={word.match(wordWithNoPunctuationExpression)}
          />,
          spaceElement
        );
        continue;
      }
    }
    setLineWords(lineElements);
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
