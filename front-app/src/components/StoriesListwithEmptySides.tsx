import React from "react";
import withEmptySides from "./withEmptySidesLayout";
import StoriesList from "../components/StoriesList"

const StoriesListWithEmptySides: React.FC<any> = withEmptySides(
  StoriesList
);

export default StoriesListWithEmptySides;
