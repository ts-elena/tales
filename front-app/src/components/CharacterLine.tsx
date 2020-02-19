import React, { useState } from "react";
import StoryData from "../mocked_data/Characters.json";
import Avatar from "./Avatar";

const CharacterLine: React.FC = () => {
  return (
    <div className="character-line">
      <Avatar image={StoryData[0].avatar_link} />
    </div>
  );
};

export default CharacterLine;
