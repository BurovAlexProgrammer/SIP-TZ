using System;
using Unity.VisualScripting;
using UnityEngine;
using Object = UnityEngine.Object;

namespace Context
{
    public class GameSessionUI : Service<GameSessionUI>, IDisposable
    {
        private readonly GameSessionUIComponent _gameSessionUIComponent;

        public GameSessionUI()
        {
            var source = Resources.Load("GameSessionUI");
            var gameObject = Object.Instantiate(source);
            _gameSessionUIComponent = gameObject.GetComponent<GameSessionUIComponent>();
        }

        public void Dispose()
        {
            Object.DestroyImmediate(_gameSessionUIComponent.gameObject);
        }
    }
}