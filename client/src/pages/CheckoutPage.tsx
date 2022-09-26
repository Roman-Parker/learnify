import { Elements } from '@stripe/react-stripe-js';
import { loadStripe } from '@stripe/stripe-js';
import { useEffect } from 'react';
import agent from '../actions/agent';
import Checkout from '../components/Checkout';
import { setBasket } from '../redux/slice/basketSlice';
import { useAppDispatch } from '../redux/store/configureStore';

const stripePromise = loadStripe('pk_test_51Llcn3GqkqnpPAh2Cec44z1WmNTMOLtVOAC4JClsHzwluPdHyaNh4OVsmy5bcsr6RfkyGNRzekBO4JklJE5YBnN200uDRaS1bY');

export default function CheckoutWrapper() {

  const dispatch = useAppDispatch()
  useEffect(() => {
    agent.Payments.paymentIntent()
    .then((basket) => dispatch(setBasket(basket)))
    .catch(error => console.log(error))
  },[dispatch])
  return (
    <Elements stripe={stripePromise}>
      <Checkout />
    </Elements>
  );
}