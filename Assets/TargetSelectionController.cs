using RPG.Units;
using System;
using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class TargetSelectionController : MonoBehaviour
{
    public static TargetSelectionController instance;

    public TargetSelectionController()
    {
        instance = this;
    }

    [SerializeField] Indicator indicator;

    BaseUnit target;

    Camera mainCam;

    bool confirm = false;

    public static event Action<BaseUnit> onConfirm;

    public void ChooseTarget()
    {
        confirm = false;
    }

    IEnumerator ChoosingTarget()
    {
        yield return null;
    }

    public void ConfirmTarget()
    {
        confirm = true;
        indicator.indicatorMeshRenderer.enabled = false;
        Debug.Log(target);
        onConfirm?.Invoke(target);
    }

    private void Start()
    {
        mainCam = Camera.main;

    }

    private void Update()
    {
        if(confirm == false && Input.GetMouseButtonDown(0))
        {
            Ray ray = mainCam.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out RaycastHit hit, 20))
            {
                if (hit.collider != null)
                {
                    var selected = hit.transform.GetComponentInParent<BaseUnit>();
                    if (selected != null)
                    {
                        target = selected;
                        indicator.transform.position = target.transform.position;
                        indicator.indicatorMeshRenderer.enabled = true;
                    }
                }
            }
        }
    }
}
