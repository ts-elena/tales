import React from "react";
import { IGreenButtonProps } from "../Interfaces/Interfaces";

const GreenButton: React.FC<IGreenButtonProps> = (props) => {
  return (
    <button
      className="green_button"
      onClick={props.onClick}
      disabled={props.isDisabled}
    >
      Continue
    </button>
  );
};

export default GreenButton;
