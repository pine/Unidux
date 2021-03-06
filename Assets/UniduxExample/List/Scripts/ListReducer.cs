﻿namespace Unidux.Example.List
{
    public static class ListReducer
    {
        public static State Reduce(State state, ListAddAction action)
        {
            state.List.Texts.Add(action.Text);
            state.List.SetStateChanged();
            return state;
        }
    }
}
