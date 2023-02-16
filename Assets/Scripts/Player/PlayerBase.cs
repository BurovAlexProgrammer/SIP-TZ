using DropItem;
using UnityEngine;

public abstract class PlayerBase : MonoBehaviour
{
    [SerializeField] private Collider _collectTrigger;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("TriggerEnter");
        if (other.CompareTag(Tags.DROP_ITEM))
        {
            var dropItem  = other.GetComponent<IDropItem>();
            dropItem.Apply(gameObject);
        }
    }
}