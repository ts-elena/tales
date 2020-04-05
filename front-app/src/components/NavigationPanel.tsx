import React from "react";
import { Link } from "react-router-dom";
import IconedText from "./IconedText";

const NavigationPanel: React.FC = () => {
  return (
    <ul className="navigation clearfix">
      <div className="navigation-link-box">
        <Link className="navigation-link-box__link" to="/stories">
          <IconedText image="/icons/story.svg" text="Stories" />
        </Link>
        <Link className="navigation-link-box__link" to="/words">
          <IconedText image="/icons/dictionary.svg" text="Words" />
        </Link>
        <Link className="navigation-link-box__link" to="/profile">
          <IconedText image="/icons/student.svg" text="Profile" />
        </Link>
      </div>
    </ul>
  );
};

export default NavigationPanel;
