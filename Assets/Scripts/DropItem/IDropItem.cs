using UnityEngine;

namespace DropItem
{
    public interface IDropItem
    {
        public void Apply(GameObject target);
        public void Destroy();
    }
}