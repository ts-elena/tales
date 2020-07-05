import React, { useState, useEffect, useRef } from "react";
import {
  getLinesSequenceNumbers,
  getLine,
  getCharacter,
  getLineAudioTrack,
} from "./../Utils/WebRequests";
import { IStoryPageParamTypesHook } from "../Interfaces/IStoryPageParamTypesHook";
import CharacterLine from "./CharacterLine";
import ContentFooter from "./ContentFooter";
import { useParams } from "react-router-dom";
import GreenButton from "./Button";
import { ILineNumber } from "../Interfaces/ILineNumber";
import Loader from "./Loader";
import { ILine } from "../Interfaces/ILine";
import { ICharacter } from "../Interfaces/ICharacter";
import ErrorBoundary from "./ErrorBoundary";

const Story: React.FC = () => {
  const [nextLineNumber, setNextLineNumber] = useState<number>(1);
  const [lines, setLines] = useState<ILine[]>([]);
  const [characters, setCharacters] = useState<ICharacter[]>([]);
  const [isLastShown, setIsLastShown] = useState<boolean>(false);

  const [error, setError] = useState<Error>();
  const [isLoading, setIsLoading] = useState<boolean>(true);

  const linesList = useRef<HTMLDivElement>(null);

  const { id } = useParams<IStoryPageParamTypesHook>();

  function handleScroll() {
    if (linesList.current !== null) {
      linesList.current.scrollTop = linesList.current.scrollHeight;
    }
  }

  async function getLineContent() {
    if (!isLastShown) {
      await getLinesSequenceNumbers(id, nextLineNumber)
        .then((result: ILineNumber) => {
          if (result.isLast === true) {
            setIsLastShown(true);
          }
          setNextLineNumber(nextLineNumber + 1);
          return Promise.all([
            getLine(result.lineId),
            getLineAudioTrack(result.storyId, result.lineId),
          ]);
        })
        .then((result: [ILine, File]) => {
          setLines(lines.concat(result[0]));
          return getCharacter(result[0].characterId);
        })
        .then((result: ICharacter) => {
          setCharacters(characters.concat(result));
          setIsLoading(false);
          handleScroll();
        })
        .catch((error: Error) => {
          setError(error);
        });
    }
  }

  useEffect(() => {
    getLineContent();
  }, []);

  return (
    <>
      <Loader isLoading={isLoading && !error} />
      <div className="story">
        {!error && (
          <div className="story__content scroll" ref={linesList}>
            <div className="story__content__lines">
              {lines.length !== 0 &&
                !isLoading &&
                lines.map((line: ILine) => (
                  <CharacterLine
                    key={line.lineId}
                    line={line}
                    character={characters.find(
                      (character) => character.characterId === line.characterId
                    )}
                    audio={`${process.env.REACT_APP_API_URL}/api/BlobExplorer/${id}/${line.lineId}.ogg`}
                  />
                ))}
            </div>
          </div>
        )}
        {lines.length !== 0 && !isLastShown && !error && (
          <ContentFooter
            children={
              <GreenButton
                isDisabled={isLoading}
                onClick={(event: React.MouseEvent) => getLineContent()}
              />
            }
          />
        )}
        {error && <ErrorBoundary hasError={true} error={error} />}
      </div>
    </>
  );
};

export default Story;
