using Services;
using UnityEngine;
using Zenject;

namespace DropItem
{
    public class DropItemCoinGood : DropItemBase
    {
        [SerializeField] private int _scores = 1;

        [Inject] private GameSessionService _gameSession; 
        
        public override void Apply(GameObject target)
        {
            Debug.Log("Collected coin");
            _gameSession.AddScores(_scores);
            base.Apply(target);
        }
    }
}