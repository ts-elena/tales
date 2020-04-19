import React, { useState, useEffect } from "react";
import ErrorBoundary from "../components/ErrorBoundary";
import StoryCover from "../components/StoryCover";
import { IStoryCover } from "../Interfaces/Interfaces";

const StoriesListPage: React.FC = () => {
  const [storyCover, setStoryCover] = useState<Array<IStoryCover>>([]);
  const [errorMessage, setErrorMessage] = useState<string>("");

  useEffect(() => {
    const abortController = new AbortController();
    const signal = abortController.signal;
    fetch(`http://localhost:3000/stories-covers`, { signal: signal })
      .then((response) => {
        if (!response.ok) {
          setErrorMessage(response.statusText);
          throw Error(response.statusText);
        }
        return response.json();
      })
      .then((data) => setStoryCover(data))
      .catch((error: Error) =>
        console.log(`The server responded with: ${error.name} ${error.message}`)
      );
    return () => {
      abortController.abort();
    };
  }, []);

  return (
    <ErrorBoundary message="Somenthing went wrong">
      <div className="stories-list">
        <div className="stories-list__container">
          {storyCover.map((story: IStoryCover) => (
            <StoryCover
              key={story.id}
              id={story.id}
              name={story.name}
              image={story.image}
            />
          ))}
          {errorMessage && <div>{errorMessage}</div>}
        </div>
      </div>
    </ErrorBoundary>
  );
};

export default StoriesListPage;
