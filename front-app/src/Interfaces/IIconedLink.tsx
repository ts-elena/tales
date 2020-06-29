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