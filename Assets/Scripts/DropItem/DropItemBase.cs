using System;
using Destruct;
using UnityEngine;
using UnityEngine.Serialization;

namespace DropItem
{
    [RequireComponent(typeof(Collider))]
    public abstract class DropItemBase : MonoBehaviour, IDropItem
    {
        [FormerlySerializedAs("_destructionPrefab")] [SerializeField] private DestructBase _destructPrefab;

        private void Awake()
        {
            OnAwake();
        }

        public virtual void Apply(GameObject target)
        {
            if (_destructPrefab != null)
            {
                _destructPrefab.Destruct();
            }
            
            Destroy(gameObject);
        }

        protected virtual void OnAwake() {}
    }
}