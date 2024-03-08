import './App.css';
import { BrowserRouter, Route, Routes } from 'react-router-dom';
import { routes } from './routes/router';


function App() {
  return (
    <BrowserRouter>
        <Routes>
          {routes?.map(({path, Component}) => 
            <Route key={path} path={path} element={<Component/>} />
          )}
        </Routes>
    </BrowserRouter>
  );
}

export default App;
