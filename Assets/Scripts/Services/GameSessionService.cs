using System;
using Cysharp.Threading.Tasks;
using Player;
using UnityEngine.SceneManagement;
using Zenject;

namespace Services
{
    public class GameSessionService : MonoServiceBase
    {
        public event Action<int> OnCoinsCountChanged;
        
        private int _coinCount;
        
        [Inject] private GameSessionUiService _gameUIService;
        [Inject] private PlayerBase _player;
        
        public int CoinCount => _coinCount;

        private void Start()
        {
            StartGame();
        }

        public void AddScores(int value)
        {
            _coinCount += value;
            OnCoinsCountChanged?.Invoke(_coinCount);
            VerifyCoinsCount();
        }

        public void StartGame()
        {
            _gameUIService.ShowGameUI();
            _gameUIService.StartGame();
            _coinCount = 0;
            OnCoinsCountChanged?.Invoke(_coinCount);
        }
        
        private void VerifyCoinsCount()
        {
            if (_coinCount >= 1) Win().Forget();
        }
        
        private async UniTaskVoid Win()
        {
            _player.SetMovementControl(false);
            await _gameUIService.PlayWin();
            StartGame();
            ReloadScene();
        }
        
        private void GameOver()
        {
            StartGame();
            ReloadScene();
        }
        
        private void ReloadScene()
        {
            SceneManager.LoadScene(Scenes.MAIN);
        }
    }
}