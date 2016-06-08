//ability

using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[System.Serializable]
public class CraftModules
{
    private ObjectInformation objectInfo;
    private List<ModuleActions> action;
    private bool selfCast;
    private float cooldown;
    private GameObject modulePrefab;
    private float energyUsed;

    public enum ModuleTypes
    {
        OFFENSIVE,
        ELECTRONIC,
        ENGINEERING,
        PROPULSION
    }

    private ModuleTypes moduleType;

    public CraftModules(ObjectInformation mObjInfo)
    {
        objectInfo = mObjInfo;
        action = new List<global::ModuleActions>();
        cooldown = 1;
        selfCast = false;
    }

    public CraftModules(ObjectInformation mObjInfo, List<ModuleActions> maction, float acooldown, GameObject modulePb)
    {
        objectInfo = mObjInfo;
        action = new List<ModuleActions>();
        action = maction;
        cooldown = acooldown;
        selfCast = false;
        modulePrefab = modulePb;
    }

    public ObjectInformation ModuleInformation
    {
        get { return objectInfo; }
    }

    public float ModuleCooldown
    {
        get { return cooldown; }
    }

    public List<ModuleActions> ModuleAction
    {
        get { return action; }
    }

    public GameObject ModulePrefab
    {
        set
        {
            modulePrefab = value;
        }
    }

    public ModuleTypes ModuleType
    {
        get
        {
            return moduleType;
        }
        set
        {
            moduleType = value;
        }
    }

    public virtual void UseModule(GameObject player)
    {
        foreach (ModuleActions ma in ModuleAction)
        {
            if (ma.ModuleActionTimes == global::ModuleActions.ActionTimes.Start)
            {
                ma.Action(player, modulePrefab);

            }
        }
    }
}