import React, { useEffect, useState, Ref, ReactNode } from "react";

const IconedText: React.FC<any> = props => {
  return (
    <div>
      <img className="link_icon" src={props.image} alt="icon" />
      {props.text}
    </div>
  );
};

export default IconedText;
