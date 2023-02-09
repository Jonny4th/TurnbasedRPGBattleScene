using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace RPG.Stats
{
    public class UnitTimer : UnitGauge 
    {
        public event Action Timed;

        [SerializeField] TMP_Text display;
    }
}
