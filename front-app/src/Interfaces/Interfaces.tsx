export interface IStoryProps {
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

export interface IGreenButtonProps {
  isDisabled: boolean;
  onClick(event: React.MouseEvent): void;
}

export interface IHintProps {
  hintText: string;
  style: object;
  className: string;
}

export interface IIconedLink {
  path: string;
  icon: IIconSet;
  text: string;
  isTextScreenResponsive?: boolean;
  isDisabled?: boolean;
}

interface IIconSet {
  monoIconPath: string;
  coloredIconPath: string;
}

export interface IErrorBoundaryState {
  hasError: boolean;
}
