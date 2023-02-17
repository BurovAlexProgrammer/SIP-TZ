using Player;
using Services;
using StarterAssets;
using UnityEngine;
using Zenject;

namespace ContextInstallers
{
    public class MainSceneContextInstaller : MonoInstaller
    {
        [SerializeField] private GameSessionUiService _gameUiService;
        [SerializeField] private GameSessionService _gameSessionService;
        [SerializeField] private PlayerBase _player;
        [SerializeField] private StarterAssetsInputs _inputs;
        
        private ServiceLocator<IService> _serviceLocator;

        public override void InstallBindings()
        {
            Container.Bind<GameSessionUiService>().FromInstance(_gameUiService).AsSingle();
            Container.Bind<GameSessionService>().FromInstance(_gameSessionService).AsSingle();
            Container.Bind<PlayerBase>().FromInstance(_player).AsSingle();
            Container.Bind<StarterAssetsInputs>().FromInstance(_inputs);
        }
    }
}