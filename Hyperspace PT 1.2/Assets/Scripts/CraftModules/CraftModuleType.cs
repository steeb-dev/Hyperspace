using UnityEngine;
using System.Collections;

public class CraftModuleType
{
    private string moduleName;
    private string moduleDescription;
    private int moduleID;

    public string ModuleName
    {
        get { return moduleName; }
        set { moduleName = value; }
    }

    public string ModuleDescription
    {
        get { return moduleDescription; }
        set { moduleDescription = value; }
    }

    public int ModuleID
    {
        get { return moduleID; }
        set { moduleID = value; }
    }

    public enum ModuleTypes
    {
        OFFENSIVE,
        ELECTRONIC,
        ENGINEERING,
        PROPULSION
    }

    private ModuleTypes moduleType;

    public ModuleTypes ModuleType
    {
        get { return moduleType; }
        set { moduleType = value; }
    }
}