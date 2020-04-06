import React from "react";
import { Link } from "react-router-dom";
import { IIconedLink } from "../Interfaces/Interfaces";

const IconedLink: React.FC<IIconedLink> = props => {
  return (
    <Link className="navigation-link-box__link" to={props.path}>
      <div>
        <img className="link_icon" src={props.icon} alt="icon" />
        {props.text}
      </div>
    </Link>
  );
};

export default IconedLink;
