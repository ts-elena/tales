import { ILine } from "./ILine";
import { ILineNumber } from "./ILineNumber";

export interface IStoryState {
  lines: Array<ILine>;
  lineSequenceNumbers: Array<ILineNumber>;
  currentLineNumber: number;
  errorMessage: string;
}
