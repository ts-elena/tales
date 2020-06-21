import React from "react";
import ErrorBoundary from "../components/ErrorBoundary";
import StoriesListWithEmptySides from "../components/StoriesListwithEmptySides";

const StoriesListPage: React.FC = () => {
  return (
    <ErrorBoundary message="Somenthing went wrong">
      <StoriesListWithEmptySides />
    </ErrorBoundary>
  );
};

export default StoriesListPage;
