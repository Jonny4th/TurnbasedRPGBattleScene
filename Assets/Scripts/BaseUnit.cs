using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RPG.Stats;

namespace RPG.Units
{
    public class BaseUnit : MonoBehaviour
    {
        public UnitTimer Timer;

        public UnitHealth Health;

        public UnitStat Strength;

        public UnitStat Toughness;

        [SerializeField] UnitActionController actionController;

        public enum State
        {
            Waiting,
            Deciding,
            Performing,
        }

    }
}

