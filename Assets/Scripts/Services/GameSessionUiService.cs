using Cysharp.Threading.Tasks;
using DG.Tweening;
using TMPro;
using UnityEngine;
using Zenject;

namespace Services
{
    public class GameSessionUiService : MonoServiceBase
    {
        [SerializeField] private CanvasGroup _gameSessionUI;
        [SerializeField] private TextMeshProUGUI _coinsCountText;
        [SerializeField] private TextMeshProUGUI _winBanner;

        [Inject] private GameSessionService _gameSessionService;

        private void Awake()
        {
            _gameSessionService.OnCoinsCountChanged += SetCoinCount;
        }

        private void OnDestroy()
        {
            _gameSessionService.OnCoinsCountChanged -= SetCoinCount;
        }

        public void StartGame()
        {
            _winBanner.rectTransform.localScale = Vector3.zero;
        }

        public async UniTask PlayWin()
        {
            _winBanner.rectTransform.localScale = Vector3.zero;
            await DOTween.Sequence()
                .Append(_winBanner.rectTransform.DOScale(0.9f, 0.5f).SetEase(Ease.InOutCubic))
                .Append(_winBanner.rectTransform.DOScale(1f, 4.5f))
                .AwaitForComplete();
        }

        public void ShowGameUI()
        {
            _gameSessionUI.DOFade(1f, 0.3f);
        }

        public void SetCoinCount(int value)
        {
            _coinsCountText.text = value.ToString();
        }
    }
}