import React, { useState, useEffect } from "react";
import ErrorBoundary from "../components/ErrorBoundary";
import StorySet from "../components/StorySet";
import { getStorySets, getStoriesBySetId } from "../Utils/WebRequests";
import { AxiosResponse } from "axios";
import { IStorySet } from "../Interfaces/IStorySet";
import { IStory } from "../Interfaces/IStory";

const StoriesListPage: React.FC = () => {
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
          {storySets.map((storySet: IStorySet) => (
            <StorySet
              key={storySet.storySetId}
              id={storySet.storySetId}
              name={storySet.storySetName}
            />
          ))}
          {errorMessage && <div>{errorMessage}</div>}
        </div>
      </div>
    </ErrorBoundary>
  );
};

export default StoriesListPage;
