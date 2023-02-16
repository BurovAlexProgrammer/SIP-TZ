using DG.Tweening;

namespace Destruct
{
    class DestructDropItem : DestructBase
    {
        public override void Destruct()
        {
            transform.DOScale(0f, 0.5f).OnComplete(() => Destroy(gameObject));
        }
    }
}