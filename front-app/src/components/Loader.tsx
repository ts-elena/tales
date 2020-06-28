import React from "react";
import { ILoaderProps } from "../Interfaces/IloaderProps";

const Loader: React.FC<ILoaderProps> = (props) => {
  return (
    <div
      className={
        props.isLoading ? "loader-container visible" : "loader-container hidden"
      }
    >
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
  );
};

export default Loader;
