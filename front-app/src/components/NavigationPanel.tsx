import React from "react";
import { Link } from "react-router-dom";

const NavigationPanel: React.FC = () => {
  return (
    <ul className="navigation clearfix">
      <li>
        <Link className="navigation__link" to="/">
          Home
        </Link>
      </li>
      <li>
        <Link className="navigation__link" to="/stories">
          Stories
        </Link>
      </li>
    </ul>
  );
};

export default NavigationPanel;
