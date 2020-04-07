import { ICharacter } from "../Interfaces/Interfaces";

export function findCharacterAvatarLink(
  characterName: string,
  characters: Array<ICharacter>
): string {
  let avatarLink: string = "";
  try {
    avatarLink =
      characters.find((element: ICharacter) => element.name === characterName)
        ?.image || "Not Found";
  } catch (e) {
    console.log(
      "Error during the search. Seems there's no key " + characterName
    );
  }
  return avatarLink;
}
