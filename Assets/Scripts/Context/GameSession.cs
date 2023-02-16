using System;

namespace Context
{
    public class GameSession : Service<GameSession>
    {
        public event Action<int> OnCoinsCountChanged;

        private int _coinCount;

        public int CoinCount => _coinCount;

        public void AddScores(int value)
        {
            _coinCount += value;
            OnCoinsCountChanged?.Invoke(_coinCount);
        }

        public void Restart()
        {
            _coinCount = 0;
            OnCoinsCountChanged?.Invoke(_coinCount);
        }
    }
}