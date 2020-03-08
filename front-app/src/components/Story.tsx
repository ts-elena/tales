import React, { useState, useEffect } from "react";
import CharacterLine from "./CharacterLine";
import { useParams } from "react-router-dom";

interface IStory {
  line: string;
  character: string;
}

interface ICharacter {
  character: string;
}

interface IParamTypes {
  id: string;
}

const Story: React.FC = (IStoryProps, IStoryState) => {
  const [characters, setCharacters] = useState<Array<ICharacter>>([]);
  const [storyLines, setStoryLines] = useState<Array<Object>>([]);

  let { id } = useParams<IParamTypes>();

  useEffect(() => {
    const abortController = new AbortController();
    const signal = abortController.signal;
    fetch("http://localhost:3000/characters", { signal: signal })
      .then(response => {
        return response.json();
      })
      .then(resp => {
        setCharacters(resp);
      })
      .catch(error => error)
      .then(() =>
        fetch("http://localhost:3000/stories")
          .then(response => {
            return response.json();
          })
          .then(resp => {
            setStoryLines(resp[id]);
          })
          .catch(error => error)
      );
    return () => {
      abortController.abort();
    };
  }, []);

  function findCharacterAvatarLink(characterName: string): any {
    let avatarLink: any = "";
    try {
      avatarLink = characters.filter((element: any) =>
        element.hasOwnProperty(characterName)
      )[0];
    } catch (e) {
      console.log(
        "error during searching. Seems there's no key " + characterName
      );
    }
    return Object.values(avatarLink)[0];
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
