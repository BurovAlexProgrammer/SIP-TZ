using UnityEngine;

namespace DropItem
{
    public class DropItemCoin : DropItemBase
    {
        public override void Apply(GameObject target)
        {
            Debug.Log("Collected");
            base.Apply(target);
        }
    }
}