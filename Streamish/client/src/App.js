import React from "react";
import { NavBar } from "./components/NavBar";
import "./App.css";
import VideoList from "./components/VideoList";

function App() {
  return (
    <div className="App">
      <NavBar />
      <VideoList />
    </div>
  );
}

export default App;

