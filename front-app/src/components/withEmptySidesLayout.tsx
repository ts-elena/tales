import React from "react";

const withEmptySides = <P extends object>(
  Component: React.ComponentType<P>
): React.FC<P> => ({ ...props }) => {
  return (
    <div className="empty-sides-layout">
      <div className="empty-sides-layout__left" />
      <Component className="empty-sides-layout__middle" {...(props as P)} />
      <div className="empty-sides-right" />
    </div>
  );
};

export default withEmptySides;
