using DG.Tweening;
using UnityEngine;

namespace DropItem
{
    [RequireComponent(typeof(Collider))]
    public abstract class DropItemBase : MonoBehaviour, IDropItem
    {
        [SerializeField] private DestructionBase _destructionPrefab;

        private Collider _collider;

        private void Awake()
        {
            _collider = GetComponent<Collider>();
            OnAwake();
        }

        public virtual void Apply(GameObject target)
        {
        }

        public virtual void Destroy()
        {
            if (_destructionPrefab != null)
            {
                _destructionPrefab.Destruct();
            }
            
            Destroy(gameObject);
        }
        
        protected virtual void OnAwake() {}
    }

    public abstract class DestructionBase : MonoBehaviour
    {
        public void Destruct()
        {
            transform.DOScale(0f, 0.5f).OnComplete(() => Destroy(gameObject));
        }
    }
}