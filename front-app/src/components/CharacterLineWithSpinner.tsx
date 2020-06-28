import React from "react";
import withSpinner from "./withSpinner";
import StoriesList from "../components/StoriesList";

const CharacterLineWithSpinner: React.FC<any> = withSpinner(StoriesList);

export default CharacterLineWithSpinner;
