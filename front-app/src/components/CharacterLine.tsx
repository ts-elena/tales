import React from "react";
import { ICharacterLineProps } from "../Interfaces/ICharacterLineProps";
import SoundPlayer from "./SoundPlayer";
import Avatar from "./Avatar";
import Line from "./Line";

const CharacterLine: React.FC<ICharacterLineProps> = (props) => {
  return (
    <>
      {props.character?.characterAvatar !== undefined && (
        <div className="character-line-wrapper">
          <Avatar avatar={props.character.characterAvatar} />
          <SoundPlayer audioSource={props.audio} />
          <Line line={props.line.lineContent} />
        </div>
      )}
    </>
  );
};

export default CharacterLine;
