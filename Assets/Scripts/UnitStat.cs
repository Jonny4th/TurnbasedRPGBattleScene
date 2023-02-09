using UnityEngine;

public class UnitStat : MonoBehaviour
{
    public string Name => name;
    [SerializeField] new string name;
    public int Value => value;
    [SerializeField] int value;
}