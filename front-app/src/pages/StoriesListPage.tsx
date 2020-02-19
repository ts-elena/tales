import React, { useState } from "react";
import StoryCover from "../components/StoryCover";
import StoriesData from "../mocked_data/story_cover.json";

const StoriesListPage: React.FC = () => {
  function clicker() {}

  return (
    <div className="stories-list">
      <div className="stories-list__container">
        {StoriesData.map(story => {
          return (
            <StoryCover name={story.name} image={story.image} id={story.id} />
          );
        })}
      </div>
    </div>
  );
};

export default StoriesListPage;
