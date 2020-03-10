import React from "react";
import { Link } from "react-router-dom";

const NavigationPanel: React.FC = () => {
  return (
    <ul className="navigation clearfix">
      <div className="navigation-link-box">
        <Link className="navigation-link-box__link" to="/">
          Home
        </Link>
        <Link className="navigation-link-box__link" to="/stories">
          Stories
        </Link>
        <Link className="navigation-link-box__link" to="/">
          Dictionary
        </Link>
        <Link className="navigation-link-box__link" to="/">
          Profile
        </Link>
      </div>
    </ul>
  );
};

export default NavigationPanel;
