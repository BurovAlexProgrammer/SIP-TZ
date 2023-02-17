using System;
using Services;
using Zenject;

namespace Context
{
    public class MainSceneContext : SceneContextBase
    {
        [Inject] private CommonUiService _commonUiService;
        
        private async void Start()
        {
            await _commonUiService.SmoothShowScene();
        }
    }
}