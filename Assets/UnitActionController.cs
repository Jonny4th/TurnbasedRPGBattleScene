using RPG.Actions;
using RPG.Units;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;

public class UnitActionController : MonoBehaviour
{
    [SerializeField] List<UnitAction> actions = new();

    private BaseUnit agent;

    private UnitAction selectedAction;

    private void Start()
    {
        agent = GetComponent<BaseUnit>();
        foreach(UnitAction action in actions)
        {
            Debug.Log(action.name);
        }
    }

    public void ChooseAction(string name)
    {
        selectedAction = actions.Find(x => x.name == name);
        Debug.Log(selectedAction.name);
        TargetSelectionController.onConfirm += PerformAction;
        TargetSelectionController.instance.ChooseTarget();
    }

    public void PerformAction(BaseUnit target)
    {
        Debug.Log(target.name);
        selectedAction.Execute(agent,target);
        TargetSelectionController.onConfirm -= PerformAction;
    }
}
