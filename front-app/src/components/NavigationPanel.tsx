import React from "react";
import IconedLink from "./IconedLink";

const NavigationPanel: React.FC = () => {
  return (
    <ul className="navigation clearfix">
      <div className="navigation-link-box">
        <IconedLink path="/stories" icon="/icons/story.svg" text="Stories" />
        <IconedLink path="/words" icon="/icons/dictionary.svg" text="Words" />
        <IconedLink path="/profile" icon="/icons/student.svg" text="Profile" />
      </div>
    </ul>
  );
};

export default NavigationPanel;
