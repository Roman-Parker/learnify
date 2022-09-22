import { Route, Routes} from 'react-router-dom';
import './sass/main.scss';
import DetailPage from './pages/DetailPage';
import Homepage from './pages/Homepage';
import LoginPage from './pages/Login';
import Navigation from './components/Navigation';
import "antd/dist/antd.css"
import Category from './components/Categories';
import CategoryPage from './pages/CategoryPage';
import DescriptionPage from './pages/DescriptionPage';
import BasketPage from './pages/BasketPage';
import { useStoreContext } from './context/StoreContext';
import { useEffect } from 'react';
import agent from './actions/agent';

function App() {

  const { setBasket } = useStoreContext();

  function getCookie(name: string) {
    return (
      document.cookie.match('(^|;)\\s*' + name + '\\s*=\\s*([^;]+)')?.pop() ||''
    );
  }

  useEffect(() => {
    const clientId = getCookie('clientId');
    if (clientId) {
      agent.Baskets.get()
        .then((basket) => setBasket(basket))
        .catch((error) => console.log(error));
    }
  }, [setBasket]);
  
  return (
    <>
      <Navigation/>
      <Routes>
        <Route path="/" element={<Category/>} />
      </Routes>
      
      <Routes>
        <Route path="/" element={<Homepage/>} />
        <Route path="/category/:id" element={<CategoryPage/>} />
        <Route path="/basket" element={<BasketPage/>} />
        <Route path="/course/:id" element={<DescriptionPage/>} />
        <Route path="/login" element={<LoginPage/>} />
        <Route path="/detail" element={<DetailPage/>} />
      </Routes>
    </>
  );
}

export default App;


