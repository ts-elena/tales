import React from "react";
import { ILoaderProps } from "../Interfaces/IloaderProps";

const withLoader = <P extends object>(
  Component: React.ComponentType<P>
): React.FC<P & ILoaderProps> => ({ isLoading, ...props }) => {
  return (
    <>
      {isLoading ? (
        <div className="loader-container">
          <div className="loader-container__space">
            <div className="stars small"></div>
            <div className="stars2 medium"></div>
            <div className="stars3 large"></div>
          </div>
          <div className="unicorn">
            <img
              src="https://images-eu.ssl-images-amazon.com/images/I/31irlaSvv1L.png"
              alt="unicorn"
            />
          </div>
        </div>
      ) : (
        <Component {...(props as P)} />
      )}
    </>
  );
};

export default withLoader;
