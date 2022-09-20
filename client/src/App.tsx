import { Route, Routes} from 'react-router-dom';
import './sass/main.scss';
import DetailPage from './pages/DetailPage';
import Homepage from './pages/Homepage';
import LoginPage from './pages/LoginPage';
import Navigation from './components/Navigation';
import "antd/dist/antd.css"
import Category from './components/Categories';
import CategoryPage from './pages/CategoryPage'

function App() {
  return (
    <>
      <Navigation/>
      <Routes>
        <Route path="/" element={<Category/>} />
      </Routes>
      
      <Routes>
        <Route path="/" element={<Homepage/>} />
        <Route path="/category/:id" element={<CategoryPage/>} />
        <Route path="/login" element={<LoginPage/>} />
        <Route path="/detail" element={<DetailPage/>} />
      </Routes>
    </>
  );
}

export default App;


