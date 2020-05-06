import React from "react";

function withLoader(wrappedComponent: React.FC) {
  return function WithLoaderComponent(isLoading: boolean, ...props) {
    return (
      <React.Fragment>
        {isLoading ? (
          <div className="loader">
            <div className="loader-ball-1" />
            <div className="loader-ball-2" />
            <div className="loader-ball-3" />
            <div className="loader-ball-4" />
          </div>
        ) : (
          wrappedComponent
        )}
      </React.Fragment>
    );
  };
}
export default withLoader;
