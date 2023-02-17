using DG.Tweening;
using UnityEngine;

namespace Destruct
{
    class DestructDropItem : DestructBase
    {
        public override void Destruct(Transform callerTransform)
        {
            base.Destruct(callerTransform);
            DOTween.Sequence()
                .Append(transform.DOScale(0f, 0.5f).SetEase(Ease.InOutCubic))
                .Join(transform.DOLocalMoveY(transform.localPosition.y + 1f, 0.5f).SetEase(Ease.InOutCubic))
                .OnComplete(() => Destroy(gameObject));
        }
    }
}