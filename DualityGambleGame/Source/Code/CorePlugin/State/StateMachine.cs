using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DualityGambleGame.State
{
    public static class StateMachine
    {
        public enum GameState
        {
            Loading,
            GeneratingBoard,
            WaitingPlayerInput,
            ShowResults,
            PlayAgain
        };

        private static GameState currentState = GameState.Loading;
        private static GameState previousState;
        
        public static void SetGameState(GameState newState)
        {
            previousState = CurrentState;

            CurrentState = newState;
        }

        public static GameState CurrentState
        {
            get
            {
                return currentState;
            }

            private set
            {
                currentState = value;
            }
        }

    }
}
