using TMPro;
using UnityEngine;

namespace Context
{
    public class GameSessionUIComponent : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI _coinsValueText;

        private void Awake()
        {
            Services.GameSession.OnCoinsCountChanged += OnCoinsCountChanged;
        }

        private void OnDestroy()
        {
            Services.GameSession.OnCoinsCountChanged -= OnCoinsCountChanged;
        }

        private void OnCoinsCountChanged(int value)
        {
            _coinsValueText.text = value.ToString();
        }
    }
}