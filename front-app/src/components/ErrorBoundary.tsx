import React from "react";
import { IAvatarProps } from "../Interfaces/IAvatarProps";

interface IErrorProps {
  hasError: boolean;
  error: Error;
}

const ErrorBoundary: React.FC<IErrorProps> = (props) => {
  return (
    <>
      {props.hasError && (
        <div className="flex-center position-r full-height">
          <div className="code">{props.error.name} </div>

          <div className="message">{props.error.message} </div>
        </div>
      )}
    </>
  );
};

export default ErrorBoundary;
