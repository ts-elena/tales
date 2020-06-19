import React from "react";
import IconedLink from "./IconedLink";

const NavigationPanel: React.FC = () => {
  return (
    <ul className="navigation clearfix">
      <div className="navigation-link-box">
        <IconedLink
          path="/stories"
          icon={{
            monoIconPath: "/icons/story_mono.svg",
            coloredIconPath: "/icons/story.svg",
          }}
          text="Stories"
          isTextScreenResponsive={true}
        />
        <IconedLink
          path="/words"
          icon={{
            monoIconPath: "/icons/dictionary_mono.svg",
            coloredIconPath: "/icons/dictionary.svg",
          }}
          text="Words"
          isTextScreenResponsive={true}
        />
        <IconedLink
          path="/profile"
          icon={{
            monoIconPath: "/icons/student_mono.svg",
            coloredIconPath: "/icons/student.svg",
          }}
          text="Profile"
          isTextScreenResponsive={true}
        />
      </div>
    </ul>
  );
};

export default NavigationPanel;
