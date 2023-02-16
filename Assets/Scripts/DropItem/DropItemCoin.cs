using Context;
using UnityEngine;

namespace DropItem
{
    public class DropItemCoin : DropItemBase
    {
        [SerializeField] private int _scores = 1;
        public override void Apply(GameObject target)
        {
            Debug.Log("Collected");
            Services.GameSession.AddScores(_scores);
            base.Apply(target);
        }
    }
}