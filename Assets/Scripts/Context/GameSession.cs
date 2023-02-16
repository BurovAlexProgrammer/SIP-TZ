using System;

namespace Context
{
    public class GameSession : Service<GameSession>
    {
        public event Action<int> OnScoresChanged;

        private int _scores;

        public int Scores => _scores;

        public void AddScores(int value)
        {
            _scores += value;
            OnScoresChanged?.Invoke(_scores);
        }

        public void Restart()
        {
            _scores = 0;
            OnScoresChanged?.Invoke(_scores);
        }
    }
}