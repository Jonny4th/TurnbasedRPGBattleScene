using RPG.Units;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RPG.Actions
{
    [CreateAssetMenu(fileName = "Defend",menuName = "Action/Defend")]
    public class Defend : UnitAction
    {
        public Defend()
        {
            name = "Defend";
        }

        public override void Execute(BaseUnit agent, BaseUnit target)
        {
            
        }
    }

}
