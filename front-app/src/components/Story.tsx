import React, { useState, useEffect } from "react";
import { getStoryData } from "./../Utils/WebRequests";
import CharacterLine from "./CharacterLine";
import { useParams } from "react-router-dom";
import axios from "axios";

interface IStory {
  line: string;
  character: string;
}

interface ICharacter {
  [character: string]: string;
}

interface IParamTypes {
  id: string;
}

const Story: React.FC = (IStoryProps, IStoryState) => {
  const [characters, setCharacters] = useState<Array<ICharacter>>([]);
  const [storyLines, setStoryLines] = useState<Array<IStory>>([]);
  const [lineIndex, setLineIndex] = useState<number>(0);

  let { id } = useParams<IParamTypes>();

  useEffect(() => {
    const fetchData = async () => {
      await Promise.all([
        (async () => {
          const { data } = await axios.get("http://localhost:3000/characters");
          setCharacters(data);
        })(),
        (() => {
          getStoryData(id).then(response => {
            setStoryLines(response);
          });
        })()
      ]);
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
      {storyLines !== undefined &&
        characters !== undefined &&
        storyLines.map((story: any) => {
          return (
            <CharacterLine
              lineText={story.line}
              imageLink={findCharacterAvatarLink(story.character)}
            />
          );
        })}
    </div>
  );
};

export default Story;
