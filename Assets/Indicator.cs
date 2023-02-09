using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Indicator : MonoBehaviour
{
    [SerializeField] GameObject model;
    public MeshRenderer indicatorMeshRenderer { get; private set; }

    private void Start()
    {
        indicatorMeshRenderer = model.GetComponent<MeshRenderer>();
        indicatorMeshRenderer.enabled = false;
    }
}
