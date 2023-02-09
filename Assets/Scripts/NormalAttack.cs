using RPG.Units;
using UnityEngine;

namespace RPG.Actions
{
    [CreateAssetMenu(fileName = "NormalAttack", menuName = "Action/Normal Attack")]
    public class NormalAttack : UnitAction
    {
        [SerializeField] float multipler;
        public NormalAttack() 
        { 
            name = "Normal Attack";
        }

        public override void Execute(BaseUnit agent, BaseUnit target)
        {
            float damage = -agent.Strength.Value * multipler;
            target.Health.AddValue(damage);
        }
    }

}
