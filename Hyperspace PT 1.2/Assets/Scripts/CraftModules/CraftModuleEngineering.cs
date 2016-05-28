using UnityEngine;
using System.Collections;

public class CraftModuleEngineering : CraftModuleStatistics
{
    private int engineeringEffect;
    private int hpRequired;

    public int EngineeringEffect
    {
        get { return engineeringEffect; }
        set { engineeringEffect = value; }
    }

    public int HpRequired
    {
        get { return hpRequired; }
        set { hpRequired = value; }
    }


    public enum ModuleEngineering
    {
        REPEAL,
        EMP,
        SHIELD,
        STEALTH
    }
    private ModuleEngineering moduleEngineer;

    public ModuleEngineering ModuleEngineer
    {
        get { return moduleEngineer; }
        set { moduleEngineer = value; }
    }

}
