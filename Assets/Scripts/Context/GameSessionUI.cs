using Unity.VisualScripting;
using UnityEngine;

namespace Context
{
    public class GameSessionUI : Service<GameSessionUI>
    {
        private Canvas _gameUiCanvas;

        public GameSessionUI()
        {
            var source = Resources.Load("GameSessionUI");
            _gameUiCanvas = source.GetComponent<Canvas>();
        }
    }
}