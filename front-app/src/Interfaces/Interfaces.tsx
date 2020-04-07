export interface IStory {
  id: string;
  image: string;
  line: string;
  character: string;
}

export interface ICharacter {
  id: string;
  name: string;
  image: string;
}

export interface IStoryPageParamTypesHook {
  id: string;
}

export interface IAxesValues {
  x: string;
  y: string;
}

export interface IAvatar {
  imageUri: string;
}

export interface IStoryCover {
  name: string;
  image: string;
  id: string;
}

export interface ICharacterLine {
  lineText: string;
  imageLink: string;
}

export interface IGreenButtonProps {
  onClick: () => {};
}

export interface IHintProps {
  hintText: string;
  style: object;
  className: string;
}

export interface IIconedLink {
  path: string;
  icon: string;
  text: string;
}
