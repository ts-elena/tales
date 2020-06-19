import React from "react";
import IconedLink from "../components/IconedLink";
import StarsBackground from "../components/StarsBackground";

const LandingPage: React.FC = () => {
  return (
    <div className="LandingPageContent">
      <StarsBackground />
      <div className="content">
        <div className="buttons-area">
          <IconedLink
            path="/stories"
            icon={{
              monoIconPath: "/icons/moon.svg",
              coloredIconPath: "/icons/moon (1).svg",
            }}
            isTextScreenResponsive={false}
            text="Start reading"
          />
        </div>
        <div className="image-container">
          <img
            src="/images/Backgrounds/Castle-removebg.png"
            alt="tea"
            id="background-image-landing"
          />
        </div>
      </div>
    </div>
  );
};

export default LandingPage;
