using Player;
using Services;
using UnityEngine;
using Zenject;

namespace Context
{
    public class MainSceneContextInstaller : MonoInstaller
    {
        [SerializeField] private GameSessionUiService _gameUiService;
        [SerializeField] private GameSessionService _gameSessionService;
        [SerializeField] private PlayerBase _player;
        
        private ServiceLocator<IService> _serviceLocator;

        public override void InstallBindings()
        {
            Container.Bind<GameSessionUiService>().FromInstance(_gameUiService).AsSingle();
            Container.Bind<GameSessionService>().FromInstance(_gameSessionService).AsSingle();
            Container.Bind<PlayerBase>().FromInstance(_player).AsSingle();
        }
    }
}