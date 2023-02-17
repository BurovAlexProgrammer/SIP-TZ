using Services;
using UnityEngine;
using Zenject;

namespace DropItem
{
    public class DropItemCoinBad : DropItemBase
    {
        [SerializeField] private int _scores = 0;

        [Inject] private GameSessionService _gameSession; 
        
        public override void Apply(GameObject target)
        {
            Debug.Log("Game Over");
            _gameSession.GameOver();
            base.Apply(target);
        }
    }
}