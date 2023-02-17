using Services;
using UnityEngine;
using Zenject;

namespace DropItem
{
    public class DropItemCoinBad : DropItemBase
    {
        [Inject] private GameSessionService _gameSession; 
        
        public override void Apply(GameObject target)
        {
            Debug.Log("Game Over");
            _gameSession.GameOver();
            base.Apply(target);
        }
    }
}