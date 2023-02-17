using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Serialization;
using Zenject;

namespace Services
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