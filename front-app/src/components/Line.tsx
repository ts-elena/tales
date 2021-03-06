import React from "react";
import InteractiveElement from "./InteractiveLineElement";
import LineElement from "./LineElement";
import { ILineProps } from "../Interfaces/ILineProps";
import {
  wordsWithApostrofies,
  wordsWithPunctuationExpression,
  wordWithNoPunctuationExpression,
  punctuationMarks,
} from "../Utils/RegexExpressions";

const Line: React.FC<ILineProps> = (props) => {
  function createLine() {
    const wordsSplitedBySpace: string[] = props.line.split(" ");
    let lineElements = [];
    const spaceElement: JSX.Element = <span>&nbsp;</span>;

    for (let word of wordsSplitedBySpace) {
      if (wordsWithApostrofies.test(word)) {
        lineElements.push(
          <InteractiveElement
            word={word.match(wordsWithApostrofies)?.toString() || ""}
          />,
          spaceElement
        );
        continue;
      }

      if (wordsWithPunctuationExpression.test(word)) {
        lineElements.push(
          <InteractiveElement
            word={word.match(wordWithNoPunctuationExpression)?.toString() || ""}
          />,
          <LineElement word={word.match(punctuationMarks)?.toString() || ""} />,
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
            word={word.match(wordWithNoPunctuationExpression)?.toString() || ""}
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
      <span className="character-line__text">{createLine()}</span>
    </div>
  );
};

export default Line;
