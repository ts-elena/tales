import React from "react";
import StoriesListPage from "./pages/StoriesListPage";
import NavigationPanel from "./components/NavigationPanel";
import { BrowserRouter as Router, Switch, Route } from "react-router-dom";
import PrivateRoute from "./Utils/PrivateRoute";
import StoryPage from "./pages/StoryPage";

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
            {process.env.REACT_APP_API_URL}
          </Route>
          <Route exact path="/login">
            I am login page
          </Route>
          <Route exact path="*">
            Sorry, the page is not found
          </Route>
        </Switch>
      </Router>
    </div>
  );
};

export default App;
