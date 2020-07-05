import React from "react";
import withEmptySides from "./withEmptySidesLayout";
import StoriesList from "../components/StoriesList";

const StoriesListWithEmptySides: React.FC = withEmptySides(StoriesList);

export default StoriesListWithEmptySides;
