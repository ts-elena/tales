import React, { useState, useEffect } from "react";
import { getStoryData, getCharacters } from "./../Utils/WebRequests";
import {
  IStory,
  ICharacter,
  IStoryPageParamTypesHook
} from "./../Utils/Interfaces";
import CharacterLine from "./CharacterLine";
import ContentFooter from "./ContentFooter";
import { useParams } from "react-router-dom";
import GreenButton from "./GreenButton";

const Story: React.FC = (IStoryProps, IStoryState) => {
  const [characters, setCharacters] = useState<Array<ICharacter>>([]);
  const [storyLines, setStoryLines] = useState<Array<IStory>>([]);
  // Как вариант, можно вообще это не хранить и в строке 28 передавать storyLines.Length
  // Это позволит выпилить и increaseCounter(), getLineData нврн тоже понадобится,
  // всё можно в useEffect будет сделать но будет менее очевидно, наверное
  const [lineIndex, setLineIndex] = useState<number>(0);

  let { id } = useParams<IStoryPageParamTypesHook>();

  function increaseCounter() {
    let nextIndex = lineIndex + 1;
    setLineIndex(nextIndex);
  }

  function getLineData() {
    getStoryData(id, lineIndex).then(response => {
      let existingLines = storyLines;
      setStoryLines(existingLines.concat(response));
      increaseCounter();
    });
  }

  useEffect(() => {
    const fetchData = async () => {
      await Promise.all([
        getCharacters().then(response => setCharacters(response)),
        getLineData()
      ]);
      increaseCounter();
    };
    fetchData();
  }, []);

  function findCharacterAvatarLink(characterName: string): string {
    let avatarLink: string = "";
    try {
      let avatarLinkSearchResult = characters.find((element: any) =>
        element.hasOwnProperty(characterName)
      );
      avatarLinkSearchResult
        ? (avatarLink = avatarLinkSearchResult[characterName])
        : (avatarLink = "Not found");
    } catch (e) {
      console.log(
        "Error during the search. Seems there's no key " + characterName
      );
    }
    return avatarLink;
  }

  return (
    <div className="story">
      {storyLines.map((story: any) => {
        return (
          <CharacterLine
            lineText={story.line}
            imageLink={findCharacterAvatarLink(story.character)}
          />
        );
      })}
      <ContentFooter children={<GreenButton onClick={() => getLineData()} />} />
    </div>
  );
};

export default Story;
