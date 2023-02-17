using System;
using Cysharp.Threading.Tasks;
using Services;
using UnityEngine;
using UnityEngine.SceneManagement;
using Zenject;

namespace Context
{
    public class BootstrapSceneContext : SceneContextBase
    {
        [SerializeField] private float _showLogoTime = 1.5f;
        
        [Inject] private CommonUiService _commonUiService;

        public async void Start()
        {
            var loadSceneAsync = SceneManager.LoadSceneAsync(Scenes.MAIN);
            loadSceneAsync.allowSceneActivation = false;
            await _commonUiService.SmoothShowScene();
            await UniTask.Delay(TimeSpan.FromSeconds(_showLogoTime));
            await _commonUiService.SmoothHideScene();
            loadSceneAsync.allowSceneActivation = true;
        }
    }
}