import { Elements } from '@stripe/react-stripe-js';
import { loadStripe } from '@stripe/stripe-js';
import Checkout from '../components/Checkout';

const stripePromise = loadStripe('pk_test_51Llcn3GqkqnpPAh2Cec44z1WmNTMOLtVOAC4JClsHzwluPdHyaNh4OVsmy5bcsr6RfkyGNRzekBO4JklJE5YBnN200uDRaS1bY');

export default function CheckoutWrapper() {
  return (
    <Elements stripe={stripePromise}>
      <Checkout />
    </Elements>
  );
}