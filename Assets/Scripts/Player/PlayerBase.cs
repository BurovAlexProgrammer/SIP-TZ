using DropItem;
using UnityEngine;

namespace Player
{
    public abstract class PlayerBase : MonoBehaviour
    {
        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag(Tags.DROP_ITEM))
            {
                var dropItem = other.GetComponent<IDropItem>();
                dropItem.Apply(gameObject);
            }
        }
    }
}