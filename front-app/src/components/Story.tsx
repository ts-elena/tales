import React, { useState, useEffect, useRef } from "react";
import {
  getLine,
  getLinesSequenceNumbers,
  getCharacter,
} from "./../Utils/WebRequests";
import { IStoryPageParamTypesHook } from "../Interfaces/Interfaces";
import { ICharacter } from "./../Interfaces/ICharacter";
import CharacterLine from "./CharacterLine";
import ContentFooter from "./ContentFooter";
import { useParams } from "react-router-dom";
import GreenButton from "./GreenButton";
import { ILineNumber } from "../Interfaces/ILineNumber";
import { ILine } from "../Interfaces/ILine";

const Story: React.FC = (props) => {
  const [lines, setLines] = useState<ILine[]>([]);
  const [characters, setCharacters] = useState<ICharacter[]>([]);
  const [lineSequenceNumbers, setLineSequenceNumbers] = useState<
    Array<ILineNumber>
  >([]);
  const [currentLineNumber, setCurrentLineNumber] = useState<number>(0);
  const [errorMessage, setErrorMessage] = useState<string>("");
  const linesList = useRef<HTMLDivElement>(null);

  const { id } = useParams<IStoryPageParamTypesHook>();

  function getLineData(
    lineId: string = lineSequenceNumbers[currentLineNumber].lineId
  ): void {
    getLine(lineId)
      .then((result: ILine) => {
        setLines(lines.concat(result));
        setCurrentLineNumber(currentLineNumber + 1);
        return result;
      })
      .then((result: ILine) => {
        return getCharacter(result.characterId);
      })
      .then((result: ICharacter) => setCharacters(characters.concat(result)))
      .catch((error: Error) => {
        setErrorMessage(error.message);
        return;
      });
  }

  function handleGetNextLineClick(event: React.MouseEvent) {
    getLineData();
    linesList.current?.scrollBy(0, 200);
  }

  function getLineCharacter(characterId: string): ICharacter {
    let characterData: ICharacter = {} as ICharacter;
    getCharacter(characterId)
      .then((result: ICharacter) => {
        characterData = result;
      })
      .catch((error: Error) => {
        setErrorMessage(error.message);
      });
    return characterData;
  }

  async function getLineNumbers() {
    await getLinesSequenceNumbers(id)
      .then((result: ILineNumber[]) => {
        setLineSequenceNumbers(
          result.sort((a: ILineNumber, b: ILineNumber): number => {
            if (a.number > b.number) return 1;
            if (a.number < b.number) return -1;
            return 0;
          })
        );
        return result;
      })
      .then((result: ILineNumber[]) =>
        getLineData(result[currentLineNumber].lineId)
      )
      .catch((error: Error) => {
        setErrorMessage(error.message);
        return;
      });
  }

  useEffect(() => {
    getLineNumbers();
  }, []);

  return (
    <div className="story">
      <div className="story__content" ref={linesList}>
        <div className="story__content__lines">
          {lines.length !== 0 &&
            characters.length !== 0 &&
            lines.map((line: ILine) => (
              <CharacterLine
                key={line.lineId}
                line={line.lineContent}
                avatar={
                  characters.find(
                    (character) => character.characterId === line.characterId
                  )?.characterAvatar || ""
                }
              />
            ))}
          <div id="anchor" />
        </div>
      </div>
      {lineSequenceNumbers.length !== lines.length && (
        <ContentFooter
          children={
            <GreenButton
              onClick={(event: React.MouseEvent) =>
                handleGetNextLineClick(event)
              }
            />
          }
        />
      )}
      {errorMessage && <div>{errorMessage}</div>}
    </div>
  );
};

export default Story;
