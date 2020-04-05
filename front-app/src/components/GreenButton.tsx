import React, { useState } from "react";

interface IGreenButtonProps {
  onClick: () => {};
}
const GreenButton: React.FC<any> = props => {
  return (
    <button className="green_button" onClick={props.onClick}>
      Continue
    </button>
  );
};

export default GreenButton;
