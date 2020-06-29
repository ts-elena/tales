import React from "react";
import { IButtonProps } from "../Interfaces/IButtonProps";

const Button: React.FC<IButtonProps> = (props) => {
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

export default Button;
