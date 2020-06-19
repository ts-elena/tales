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

  return (
    <NavLink
      className={"navigation-link-box__link"}
      to={props.path}
      activeClassName="active"
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
