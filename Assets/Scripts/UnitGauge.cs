using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RPG.Stats
{
    public class UnitGauge : MonoBehaviour
    {
        public float Value 
        { 
            get => value; 
            set 
            { 
                this.value = value; 
                ValueChanged?.Invoke(this.value); 
            } 
        }
        [SerializeField] float value;

        public float Max { get { return value; } }
        [SerializeField] float max;

        public event Action<float> ValueChanged;

        public void AddValue(float value)
        {
            this.value += value;
        }

        public void SetValue(float value)
        {
            this.value = value;
        }
    }
}
