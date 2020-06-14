import axios, { AxiosResponse } from "axios";
import { IStoryData } from "./../Interfaces/IStory";
import { ILine } from "./../Interfaces/ILine";
import { ILineSequence } from "./../Interfaces/ILineSequence";
import { ICharacter } from "./../Interfaces/ICharacter";

export async function getTranslation(textToTranslate: string): Promise<string> {
  const translatorUri =
    "https://translate.yandex.net/api/v1.5/tr.json/translate?key=trnsl." +
    `${process.env.REACT_APP_TRANSLATOR_API_KEY}&text=${textToTranslate}&lang=en-ru`;
  try {
    const { data } = await axios.get(translatorUri);
    return data.text;
  } catch (error) {
    console.log(error);
    return "Not found";
  }
}

export async function getStoriesOfSet(
  setId: string
): Promise<AxiosResponse<IStoryData>> {
  return await axios.get(
    process.env.REACT_APP_API_URL + "/api/Story/GetStoriesOfSet/" + setId
  );
}

export async function getStorySets() {
  const { data } = await axios.get(
    process.env.REACT_APP_API_URL + "/api/StorySet"
  );
  return data;
}

export async function getCharacter(
  id: string
): Promise<AxiosResponse<ICharacter>> {
  return await axios.get(
    `${process.env.REACT_APP_API_URL}/api/Character/${id}`
  );
}

export async function getLinesSequence(
  storyId: string
): Promise<AxiosResponse<ILineSequence>> {
  return await axios.get(
    `${process.env.REACT_APP_API_URL}/api/LineNumber/${storyId}`
  );
}

export async function getLine(lineId: string): Promise<AxiosResponse<ILine>> {
  return await axios.get(`${process.env.REACT_APP_API_URL}/api/Line/${lineId}`);
}
