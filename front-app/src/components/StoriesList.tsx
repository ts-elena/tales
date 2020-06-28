import React, { useState, useEffect } from "react";
import ErrorBoundary from "../components/ErrorBoundary";
import StorySet from "../components/StorySet";
import { getStorySets } from "../Utils/WebRequests";
import { IStorySet } from "../Interfaces/IStorySet";
import Loader from "./Loader";

const StoriesList: React.FC<any> = () => {
  const [storySets, setStorySets] = useState<Array<IStorySet>>([]);
  const [isLoading, setIsLoading] = useState<boolean>(true);
  const [errorMessage, setErrorMessage] = useState<string>("");

  useEffect(() => {
    getStorySets()
      .then((result: IStorySet[]) => {
        setStorySets(result);
        setTimeout(() => setIsLoading(false), 3000);
      })
      .catch((error: Error) => console.log(error.message));
  }, []);

  return (
    <>
      <Loader isLoading={isLoading} />
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
    </>
  );
};

export default StoriesList;
