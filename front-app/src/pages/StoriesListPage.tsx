import React, { useState, useEffect } from "react";
import ErrorBoundary from "../components/ErrorBoundary";
import StoryCover from "../components/StoryCover";
import { getStorySets } from "../Utils/WebRequests";
import { AxiosResponse } from "axios";
import { IStorySet } from "../Interfaces/IStorySet";
import { IStory } from "../Interfaces/IStory";

const StoriesListPage: React.FC = () => {
  const [stories, setStories] = useState<Array<IStory>>([]);
  const [storySets, setStorySets] = useState<Array<IStorySet>>([]);
  const [errorMessage, setErrorMessage] = useState<string>("");

  useEffect(() => {
    getStorySets()
      .then((result: IStorySet[]) => {
        setStorySets(result);
      })
      .catch((error: Error) => console.log(error.message));
  }, []);

  return (
    <ErrorBoundary message="Somenthing went wrong">
      <div className="stories-list">
        <div className="stories-list__container">
          {stories.map((story: IStory) => (
            <StoryCover
              key={story.StoryId}
              id={story.StoryId}
              name={story.StoryName}
              image={story.StoryCoverImage}
            />
          ))}
          {errorMessage && <div>{errorMessage}</div>}
        </div>
      </div>
    </ErrorBoundary>
  );
};

export default StoriesListPage;
