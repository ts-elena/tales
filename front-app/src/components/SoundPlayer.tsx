import React, { useState, useRef } from "react";
import { ISoundPlayerProps } from "../Interfaces/ISoundPlayerProps";

const SoundPlayer: React.FC<ISoundPlayerProps> = (props) => {
  const [isMonoIcon, setIsMonoIcon] = useState<boolean>(true);
  const audioTag = useRef<HTMLAudioElement>(null);

  function playAudio() {
    if (audioTag.current?.currentTime === 0) {
      audioTag.current?.play();
    } else {
      audioTag.current?.pause();
      if (audioTag.current !== null) {
        audioTag.current.currentTime = 0;
      }
    }
  }
  return (
    <>
      <audio
        src={props.audioSource}
        ref={audioTag}
        onPlay={() => setIsMonoIcon(false)}
        onPause={() => setIsMonoIcon(true)}
      />
      <img
        className="sound-player-icon"
        src={isMonoIcon ? "/icons/speaker_mono.svg" : "/icons/speaker.svg"}
        alt="audio"
        onClick={() => playAudio()}
      />
    </>
  );
};

export default SoundPlayer;
