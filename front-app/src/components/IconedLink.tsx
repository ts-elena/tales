import React, { useState, useEffect } from "react";
import { NavLink, useLocation, useHistory } from "react-router-dom";
import { IIconedLink } from "../Interfaces/Interfaces";

const IconedLink: React.FC<IIconedLink> = (props) => {
  const [location, setLocation] = useState(useHistory().location);
  const [isLocation, setIsLocation] = useState(
    location.pathname.includes(props.path)
  );
  const [isLandingPage, setIsLandingPage] = useState<boolean>(
    location.pathname === "/"
  );

  const history = useHistory();
  history.listen((currentLocation) => {
    setLocation(currentLocation);
    setIsLocation(currentLocation.pathname.includes(props.path));
    setIsLandingPage(currentLocation.pathname === "/");
  });

  function handleDisabledState(event: React.MouseEvent) {
    if (props.isDisabled) {
      event.preventDefault();
    }
  }

  return (
    <NavLink
      className={
        props.isDisabled === true
          ? "navigation-link-box__link disabled"
          : "navigation-link-box__link"
      }
      title={props.isDisabled ? "I am coming soon! Stay tuned" : props.text}
      to={props.path}
      activeClassName="active"
      onClick={(event: React.MouseEvent) => handleDisabledState(event)}
    >
      <div>
        <img
          className="link_icon"
          src={
            isLocation || isLandingPage
              ? props.icon.coloredIconPath
              : props.icon.monoIconPath
          }
          alt="icon"
        />
        <span
          className={`link-text${
            props.isTextScreenResponsive ? "__responsive" : ""
          } ${isLandingPage && "white"}`}
        >
          {props.text}
        </span>
      </div>
    </NavLink>
  );
};

export default IconedLink;
