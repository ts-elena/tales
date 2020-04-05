export interface IStory {
  line: string;
  character: string;
}

export interface ICharacter {
  [character: string]: string;
}

export interface IStoryPageParamTypesHook {
  id: string;
}

export interface IAvatar {
  image: string;
}
