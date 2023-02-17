using Services;
using UnityEngine;
using UnityEngine.Serialization;
using Zenject;

namespace ContextInstallers
{
    public class ProjectContextInstaller : MonoInstaller
    {
        [FormerlySerializedAs("_commonUiServicePrefab")] [SerializeField] private CommonUiService _commonUiService;

        public override void InstallBindings()
        {
            Container
                .Bind<CommonUiService>()
                .FromInstance(_commonUiService)
                .AsSingle()
                .NonLazy();
        }
    }
}