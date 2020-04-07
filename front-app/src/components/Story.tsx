import React, { useState, useEffect } from "react";
import { getStoryData, getCharacters } from "./../Utils/WebRequests";
import {
  IStory,
  ICharacter,
  IStoryPageParamTypesHook
} from "../Interfaces/Interfaces";
import { findCharacterAvatarLink } from "./../Utils/UtilityFunctions";
import CharacterLine from "./CharacterLine";
import ContentFooter from "./ContentFooter";
import { useParams } from "react-router-dom";
import GreenButton from "./GreenButton";

const Story: React.FC = (IStoryProps, IStoryState) => {
  const [characters, setCharacters] = useState<Array<ICharacter>>([]);
  const [storyLines, setStoryLines] = useState<Array<IStory>>([]);
  const [lineIndex, setLineIndex] = useState<number>(0);

  const { id } = useParams<IStoryPageParamTypesHook>();

  function increaseCounter(): void {
    setLineIndex(lineIndex + 1);
  }

  async function getLineData() {
    const storyData = await getStoryData(id, lineIndex);
    setStoryLines(storyLines.concat(storyData));
    increaseCounter();
  }

  useEffect(() => {
    async function fetchData() {
      await Promise.all([
        (async () => {
          const allCharacters = await getCharacters();
          setCharacters(allCharacters);
        })(),
        getLineData()
      ]);
    }
    fetchData();
  }, []);

  return (
    <div className="story">
      {storyLines.map((story: any) => {
        return (
          <CharacterLine
            lineText={story.line}
            imageLink={findCharacterAvatarLink(story.character, characters)}
          />
        );
      })}
      <ContentFooter children={<GreenButton onClick={() => getLineData()} />} />
    </div>
  );
};

export default Story;
