import React, { ReactElement } from "react";
import StoriesListPage from "./pages/StoriesListPage";
import NavigationPanel from "./components/NavigationPanel";
import LandingPage from "./pages/LandingPage";
import { BrowserRouter as Router, Switch, Route } from "react-router-dom";
import PrivateRoute from "./Utils/PrivateRoute";
import StoryPage from "./pages/StoryPage";
import Test from "./pages/Test";

const App: React.FC = () => {
  return (
    <div className="main-content">
      <Router>
        <NavigationPanel />
        <Switch>
          <PrivateRoute exact path="/stories/:id" children={<StoryPage />} />
          <PrivateRoute exact path="/stories" children={<StoriesListPage />} />
          <PrivateRoute exact path="/words" />
          <PrivateRoute exact path="/profile"></PrivateRoute>
          <Route exact path="/">
            I am home page
          </Route>
        </Switch>
      </Router>
    </div>
  );
};

export default App;
