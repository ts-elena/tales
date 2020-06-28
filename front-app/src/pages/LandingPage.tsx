import React, { useState } from "react";
import IconedLink from "../components/IconedLink";
import StarsBackground from "../components/StarsBackground";
import Loader from "../components/Loader";

const LandingPage: React.FC = () => {
  const [isLoading, setIsLoading] = useState<boolean>(true);
  function handleOnLoad() {
    setTimeout(() => setIsLoading(false), 2000);
  }
  return (
    <>
      <Loader isLoading={isLoading} />
      <div
        className="LandingPageContent"
        style={{ display: isLoading ? "none" : "" }}
      >
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
              onLoad={() => handleOnLoad()}
            />
          </div>
        </div>
      </div>
    </>
  );
};

export default LandingPage;
