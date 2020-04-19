import React, { useState } from "react";
import { NavLink, useLocation } from "react-router-dom";
import { useHistory } from "react-router";
import { IIconedLink } from "../Interfaces/Interfaces";

const IconedLink: React.FC<IIconedLink> = (props) => {
  const [location, setLocation] = useState(useLocation());
  const history = useHistory();

  history.listen((location) => setLocation(location));

  return (
    <NavLink
      className="navigation-link-box__link"
      to={props.path}
      activeClassName="active"
    >
      <div>
        <img
          className="link_icon"
          src={
            location.pathname === props.path
              ? props.icon.coloredIconPath
              : props.icon.monoIconPath
          }
          alt="icon"
        />
        {props.text}
      </div>
    </NavLink>
  );
};

export default IconedLink;
