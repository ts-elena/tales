import React, { useState, useEffect } from "react";
import { IStorySetProps } from "../Interfaces/IStorySetProps";
import { getStoriesBySetId } from "../Utils/WebRequests";
import { IStory } from "../Interfaces/IStory";
import StoryCover from "./StoryCover";

const StorySet: React.FC<IStorySetProps> = (props) => {
  const [stories, setStories] = useState<IStory[]>([]);

  useEffect(() => {
    getStoriesBySetId(props.id)
      .then((result: IStory[]) => {
        setStories(result);
      })
      .catch((error: Error) => console.log(error.message));
  }, []);

  return (
    <div className="story-set">
      <div>{props.name}</div>
      {stories.map((story: IStory, index: number) => (
        <StoryCover
          key={story.storyId}
          id={story.storyId}
          name={story.storyName}
          image={story.storyCoverImage}
        />
      ))}
    </div>
  );
};

export default StorySet;
