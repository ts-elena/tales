import React from "react";
import Avatar from "./Avatar";
import InteractiveElement from "./InteractiveLineElement";
import LineElement from "./LineElement";
import { ICharacterLineProps } from "../Interfaces/ICharacterLineProps";
import {
  wordsWithApostrofies,
  wordsWithPunctuationExpression,
  wordWithNoPunctuationExpression,
  punctuationMarks,
} from "./../Utils/RegexExpressions";

const CharacterLine: React.FC<ICharacterLineProps> = (props) => {
  function createLine() {
    const wordsSplitedBySpace: string[] = props.line.split(" ");
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
      <Avatar imageUri={props.avatar} />
      <span className="character-line__text">{createLine()}</span>
    </div>
  );
};

export default CharacterLine;
