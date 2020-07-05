import React from "react";
import { IAvatarProps } from "../Interfaces/IAvatarProps";

const Avatar: React.FC<IAvatarProps> = (props) => {
  return <img src={props.avatar} alt="avatar" className="avatar__image" />;
};

export default Avatar;
