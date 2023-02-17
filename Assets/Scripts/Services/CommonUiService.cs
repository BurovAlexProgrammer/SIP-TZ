using Cysharp.Threading.Tasks;
using DG.Tweening;
using UnityEngine;

namespace Services
{
    public class CommonUiService : MonoServiceBase
    { 
        [SerializeField] private CanvasGroup _cameraFrame;

        public async UniTask SmoothShowScene()
        {
            _cameraFrame.alpha = 1f;
            await _cameraFrame.DOFade(0f, 1f).AsyncWaitForCompletion();
        }
        
        public async UniTask SmoothHideScene()
        {
            await _cameraFrame.DOFade(1f, 1f).AsyncWaitForCompletion();
        } 
    }
}