import { Route, Switch} from 'react-router-dom';
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
import { useEffect } from 'react';
import { useAppDispatch } from './redux/store/configureStore';
import { fetchBasketAsync, setBasket } from './redux/slice/basketSlice';
import Dashboard from './pages/Dashboard';
import { getUser } from './redux/slice/userSlice';
import Login from './pages/Login';
import Categories from './components/Categories';
import PrivateRoute from './components/PrivateRoute';

function App() {


  const dispatch = useAppDispatch();

  function getCookie(name: string) {
    return (
      document.cookie.match('(^|;)\\s*' + name + '\\s*=\\s*([^;]+)')?.pop() ||
      ''
    );
  };

  useEffect(() => {
    dispatch(fetchBasketAsync());
    dispatch(getUser());
  }, [dispatch]);
  
  return (
    <>
      <Navigation />
      <Route exact path="/" component={Categories} />
      <Switch>
        <Route exact path="/" component={Homepage} />
        <Route exact path="/course/:id" component={DescriptionPage} />
        <Route exact path="/basket" component={BasketPage} />
        <Route exact path="/category/:id" component={CategoryPage} />
        <Route exact path="/login" component={Login} />
        <Route exact path="/detail" component={DetailPage} />
        <PrivateRoute exact path="/profile" component={Dashboard} />
      </Switch>
    </>
  );
}

export default App;


