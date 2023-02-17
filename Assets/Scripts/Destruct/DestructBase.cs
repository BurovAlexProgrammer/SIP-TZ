using UnityEngine;

namespace Destruct
{
    public abstract class DestructBase : MonoBehaviour
    {
        public virtual void Destruct(Transform callerTransform)
        {
            transform.position = callerTransform.position;
        }
    }
}