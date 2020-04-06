import { ICharacter } from "../Interfaces/Interfaces";

export function findCharacterAvatarLink(
  characterName: string,
  characters: Array<ICharacter>
): string {
  let avatarLink: string = "";
  try {
    let avatarLinkSearchResult = characters.find((element: any) =>
      element.hasOwnProperty(characterName)
    );
    avatarLinkSearchResult
      ? (avatarLink = avatarLinkSearchResult[characterName])
      : (avatarLink = "Not found");
  } catch (e) {
    console.log(
      "Error during the search. Seems there's no key " + characterName
    );
  }
  return avatarLink;
}
