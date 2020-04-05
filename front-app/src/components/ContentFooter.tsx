import React, { useState } from "react";

interface IContentFooterProps {}
const ContentFooter: React.FC<IContentFooterProps> = props => {
  return <div className="content_footer">{props.children}</div>;
};

export default ContentFooter;
