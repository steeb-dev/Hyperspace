//behvaior

using UnityEngine;
using System.Collections;

public class ModuleActions {

    private ObjectInformation objectInfo;

    public enum ActionTimes {
        Start,
        Middle,
        End,
    }

    private ActionTimes actionTime;

    public ModuleActions(ObjectInformation objInfo, ActionTimes atime)
    {
        objectInfo = objInfo;
        actionTime = atime;

    }

    public virtual void Action(GameObject playerObject, GameObject objectHit)
    {
        Debug.LogWarning("Need to add action to ablility");
    }

    public ObjectInformation ModuleActionInformation
    {
        get { return objectInfo; }
    }

    public ActionTimes ModuleActionTimes
    {
        get { return actionTime; }
    }
}
