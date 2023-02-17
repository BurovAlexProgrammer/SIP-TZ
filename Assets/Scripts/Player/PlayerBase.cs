using DropItem;
using Plugins.FPC;
using UnityEngine;
using Zenject;

namespace Player
{
    public abstract class PlayerBase : MonoInstaller
    {
        [SerializeField] private FirstPersonController _firstPersonController;

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag(Tags.DROP_ITEM))
            {
                var dropItem = other.GetComponent<IDropItem>();
                dropItem.Apply(gameObject);
            }
        }

        public void SetMovementControl(bool state)
        {
            _firstPersonController.enabled = state;
        }
        
    }
}