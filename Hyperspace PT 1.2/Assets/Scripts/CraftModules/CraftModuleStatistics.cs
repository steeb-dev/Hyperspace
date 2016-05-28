using UnityEngine;
using System.Collections;

public class CraftModuleStatistics : CraftModuleType
{
    private int energyRequiredOnUse;
    private int mountPointRequired;
    private int powerUsage;

    public int EnergyRequiredOnUse
    {
        get { return energyRequiredOnUse; }
        set { energyRequiredOnUse = value; }
    }
    public int MountPointRequired
    {
        get { return mountPointRequired; }
        set { mountPointRequired = value; }
    }
    public int PowerUsage
    {
        get { return powerUsage; }
        set { powerUsage = value; }
    }

}
