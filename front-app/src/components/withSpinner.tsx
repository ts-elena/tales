import React from "react";
import { ILoaderProps } from "../Interfaces/IloaderProps";
import Spinner from "./Spinner";

const withSpinner = <P extends object>(
  Component: React.ComponentType<P>
): React.FC<P & ILoaderProps> => ({ isLoading, ...props }) => {
  return <>{isLoading ? <Spinner /> : <Component {...(props as P)} />}</>;
};

export default withSpinner;
