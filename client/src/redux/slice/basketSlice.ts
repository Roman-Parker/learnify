import { createAsyncThunk, createSlice } from '@reduxjs/toolkit';
import agent from '../../actions/agent';
import { Basket } from '../../models/basket';

interface BasketState {
  basket: Basket | null | undefined;
  status: string;
}

const initialState: BasketState = {
  basket: null,
  status: 'idle',
};

export const addBasketItemAsync = createAsyncThunk<Basket | undefined, {courseId: string}>(
    'basket/addBasketItemAsync', 
    async({courseId}) => {
        try {
            return await agent.Baskets.addItem(courseId)
        } catch (error) {
            console.log(error)
        }
})

export const removeBasketItemAsync = createAsyncThunk<void, {courseId: string}>(
  "basket/removeBasketItemAsync",
  async ({courseId}) => {
    try {
      await agent.Baskets.removeItem(courseId);
    } catch (error) {
      console.log(error)
    }
  }
)

export const basketSlice = createSlice({
  name: 'basket',
  initialState,
  reducers: {
    setBasket: (state, action) => {
      state.basket = action.payload;
    },
    
  },
  extraReducers: (builder) => {
    builder.addCase(addBasketItemAsync.pending, (state, action) => {
        state.status = 'pending'
    });
    builder.addCase(addBasketItemAsync.fulfilled, (state, action) => {
        state.basket = action.payload;
        state.status = 'idle'
    });
    builder.addCase(addBasketItemAsync.rejected, (state, action) => {
      state.status = 'idle'
  });
    builder.addCase(removeBasketItemAsync.pending, (state, action) => {
      state.status = 'pending'
    });
    builder.addCase(removeBasketItemAsync.fulfilled, (state, action) => {
      state.status = 'idle'
      const { courseId } = action.meta.arg;
      const itemIndex = state.basket?.items.findIndex(
        (i) => i.courseId === courseId,
      );
      if (itemIndex === undefined || itemIndex === -1) return;
      state.basket?.items.splice(itemIndex, 1);
    });
    builder.addCase(removeBasketItemAsync.rejected, (state, action) => {
      state.status = 'idle';
    });
    
  }
});

export const { setBasket } = basketSlice.actions;