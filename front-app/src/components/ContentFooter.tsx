import React from "react";

interface IContentFooterProps {
  children: JSX.Element;
}
const ContentFooter: React.FC<IContentFooterProps> = (props) => {
  return <div className="content_footer">{props.children}</div>;
};

export default ContentFooter;
