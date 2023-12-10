import { createSlice } from '@reduxjs/toolkit';
import { CounterState } from '../entities/CounterState';

const initialState: CounterState = {
    count: 0
}

// Создаёт редюсер (reducer) для обработки состояния (state) использую срез (slice) RTK 
const counterSlice = createSlice({
    name: 'counter',
    initialState,
    reducers: {
        increment(state) {
            state.count++
        },
        decrement(state) {
            state.count--
        }
    }
})

export const counterActionIncrement = counterSlice.actions.increment;
export const counterReducer = counterSlice.reducer;
