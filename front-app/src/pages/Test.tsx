import React, { useState } from "react";

const CharacterLine: React.FC<any> = props => {
  const handleChange = (e: any) => {
    console.log(e.target.value);
  };

  return <input onChange={handleChange} />;
};

export default CharacterLine;
