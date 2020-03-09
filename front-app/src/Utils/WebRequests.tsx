import axios from "axios";

export function getStoriesData(abortController: AbortController): [] {
  const signal = abortController.signal;
  fetch(`localhost:3000/stories`, { signal: signal })
    .then(response => response.json())
    .then(data => {
      return data;
    })
    .catch(error => {
      return error;
    });
  return [];
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
  // const signal = abortController.signal;
  const { data } = await axios.get("http://localhost:3000/characters");
  return data;
}
