import axios, { AxiosResponse } from "axios";
import { IStory } from "./../Interfaces/IStory";
import { ILine } from "./../Interfaces/ILine";
import { ILineNumber } from "../Interfaces/ILineNumber";
import { ICharacter } from "./../Interfaces/ICharacter";
import { IStorySet } from "../Interfaces/IStorySet";
import { IStorySetNumber } from "../Interfaces/IStorySetNumber";

export async function getTranslation(textToTranslate: string): Promise<string> {
  return await axios
    .get(
      `https://translate.yandex.net/api/v1.5/tr.json/translate?key=trnsl.
      ${process.env.REACT_APP_TRANSLATOR_API_KEY}&text=${textToTranslate}&lang=en-ru`
    )
    .then(
      (result: AxiosResponse<string>): string => {
        return result.data;
      },
      (error: Error) => {
        throw GetErrorWithTemplate(error);
      }
    );
}

export async function getStoriesBySetId(setId: string): Promise<IStory[]> {
  return await axios
    .get(`${process.env.REACT_APP_API_URL}/api/Story/GetStoriesOfSet/${setId}`)
    .then(
      (result: AxiosResponse<IStory[]>): IStory[] => {
        return result.data;
      },
      (error: Error) => {
        throw GetErrorWithTemplate(error);
      }
    );
}

export async function getStorySets(): Promise<IStorySet[]> {
  return await axios.get(`${process.env.REACT_APP_API_URL}/api/StorySet`).then(
    (result: AxiosResponse<IStorySet[]>): IStorySet[] => {
      return result.data;
    },
    (error: Error) => {
      throw GetErrorWithTemplate(error);
    }
  );
}

export async function getStorySetSequenceNumbers(): Promise<IStorySetNumber[]> {
  return await axios
    .get(`${process.env.REACT_APP_API_URL}/api/StorySetNumber`)
    .then(
      (result: AxiosResponse<IStorySetNumber[]>): IStorySetNumber[] => {
        return result.data;
      },
      (error: Error) => {
        throw GetErrorWithTemplate(error);
      }
    );
}

export async function getCharacter(id: string): Promise<ICharacter> {
  return await axios
    .get(`${process.env.REACT_APP_API_URL}/api/Character/${id}`)
    .then(
      (result: AxiosResponse<ICharacter>): ICharacter => {
        return result.data;
      },
      (error: Error) => {
        throw GetErrorWithTemplate(error);
      }
    );
}

export async function getLinesSequenceNumbers(
  storyId: string
): Promise<ILineNumber[]> {
  return await axios
    .get(`${process.env.REACT_APP_API_URL}/api/LineNumber/${storyId}`)
    .then(
      (result: AxiosResponse<ILineNumber[]>): ILineNumber[] => {
        return result.data;
      },
      (error: Error) => {
        throw GetErrorWithTemplate(error);
      }
    );
}

export async function getLine(lineId: string): Promise<ILine> {
  return await axios
    .get(`${process.env.REACT_APP_API_URL}/api/Line/${lineId}`)
    .then(
      (result: AxiosResponse<ILine>): ILine => {
        return result.data;
      },
      (error: Error) => {
        throw GetErrorWithTemplate(error);
      }
    );
}

function GetErrorWithTemplate(error: Error): Error {
  return new Error(
    `Endpoint returned '${error.name}' error with message '${error.message}'`
  );
}
