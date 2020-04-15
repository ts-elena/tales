import React from "react";
import { IErrorBoundaryState } from "../Interfaces/Interfaces";

interface IErrorBoundaryProps {
  message: string;
}
class ErrorBoundary extends React.Component<
  IErrorBoundaryProps,
  IErrorBoundaryState
> {
  constructor(props: IErrorBoundaryProps) {
    super(props);
    this.state = { hasError: false };
  }

  static getDerivedStateFromError() {
    // Update state so the next render will show the fallback UI.
    return { hasError: true };
  }

  render() {
    if (this.state.hasError) {
      // You can render any custom fallback UI
      return <h1>{this.props.message}</h1>;
    }

    return this.props.children;
  }
}

export default ErrorBoundary;
