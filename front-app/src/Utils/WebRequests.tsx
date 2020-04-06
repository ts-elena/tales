import axios from "axios";

export async function getStoryData(id: string, lineIndex: number) {
  const { data } = await axios.get("http://localhost:3000/stories");
  return data[id][lineIndex];
}

export async function getTranslation(textToTranslate: string) {
  const translatorUri = `https://translate.yandex.net/api/v1.5/tr.json/translate?key=trnsl.
  1.1.20200315T160048Z.dedf3bba1e50b1e2.a64656b485b813cf25d248e159d64421bf78ebc9&text=${textToTranslate}&lang=en-ru`;
  const { data } = await axios.get(translatorUri);
  return data.text;
}

export function getStoriesCovers(abortController: AbortController) {
  const signal = abortController.signal;
  fetch("localhost:3000/stories-covers", { signal: signal })
    .then(response => {
      return response.json();
    })
    .then(data => data)
    .catch(error => error);
}

export async function getCharacters() {
  const { data } = await axios.get("http://localhost:3000/characters");
  return data;
}
