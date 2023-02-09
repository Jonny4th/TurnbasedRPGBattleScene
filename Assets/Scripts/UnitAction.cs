using RPG.Units;
using UnityEngine;

namespace RPG.Actions
{
    public class UnitAction : ScriptableObject, IExecutable
    {
        [SerializeField] protected new string name;
        public virtual void Execute(BaseUnit agent, BaseUnit target) { }
    }

}