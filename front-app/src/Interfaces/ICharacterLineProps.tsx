import { ILine } from "./ILine";
import { ICharacter } from "./ICharacter";
export interface ICharacterLineProps {
  line: ILine;
  character: ICharacter | undefined;
  audio: string;
}
