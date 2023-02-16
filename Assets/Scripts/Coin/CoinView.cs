using System.Threading;
using Cysharp.Threading.Tasks;
using UnityEngine;

namespace Coin
{
    public class CoinView : MonoBehaviour, ICoin
    {
        [SerializeField] private bool _animated = true;
        [SerializeField] private float _spinSpeed = 30;

        private Transform _transform;
        private CancellationToken _cancellationToken;

        private void Awake()
        {
            _transform = transform;
            _cancellationToken = gameObject.GetCancellationTokenOnDestroy();
        }

        void OnEnable()
        {
            if (_animated)
            {
                RunSpin().Forget();
            }
        }

        private async UniTaskVoid RunSpin()
        {
            while (!_cancellationToken.IsCancellationRequested)
            {
                transform.Rotate(Vector3.up * _spinSpeed * Time.deltaTime);
                await UniTask.NextFrame(_cancellationToken);
            }
        }
    }
}
