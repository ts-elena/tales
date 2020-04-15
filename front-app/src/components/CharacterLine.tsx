import React from "react";
import Avatar from "./Avatar";
import InteractiveElement from "./InteractiveLineElement";
import LineElement from "./LineElement";
import { ICharacterLine } from "../Interfaces/Interfaces";
import {
  wordsWithApostrofies,
  wordsWithPunctuationExpression,
  wordWithNoPunctuationExpression,
  punctuationMarks,
} from "./../Utils/RegexExpressions";

const CharacterLine: React.FC<ICharacterLine> = (props) => {
  function createLine() {
    const wordsSplitedBySpace: string[] = props.lineText.split(" ");
    let lineElements = [];
    const spaceElement: JSX.Element = <span>&nbsp;</span>;

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
    return lineElements;
  }

  return (
    <div className="character-line">
      <Avatar imageUri={props.imageLink} />
      <span className="character-line__text">{createLine()}</span>
    </div>
  );
};

export default CharacterLine;
