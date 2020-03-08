import React, { useState, useEffect } from "react";
import StoryCover from "../components/StoryCover";
import { getStoriesCovers } from "./../Utils/WebRequests";
import { stringify } from "querystring";

interface StoryCover {
  name: string;
  image: string;
  id: string;
}
const StoriesListPage: React.FC = () => {
  const [storyCover, setStoryCover] = useState([]);

  useEffect(() => {
    const abortController = new AbortController();
    const signal = abortController.signal;
    fetch(`http://localhost:3000/stories-covers`, { signal: signal })
      .then(response => {
        return response.json();
      })
      .then(data => setStoryCover(data))
      .catch(error => error);
    return () => {
      abortController.abort();
    };
  }, []);

  return (
    <div className="stories-list">
      <div className="stories-list__container">
        {storyCover.map((story: StoryCover) => (
          <StoryCover
            key={story.id}
            id={story.id}
            name={story.name}
            image={story.image}
          />
        ))}
      </div>
    </div>
  );
};

export default StoriesListPage;
