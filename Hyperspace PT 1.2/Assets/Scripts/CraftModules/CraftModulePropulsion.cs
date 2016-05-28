using UnityEngine;
using System.Collections;

public class CraftModulePropulsion : CraftModuleStatistics
{
    private int propulsionEffect;
    private int hpRequired;

    public int PropulsionEffect
    {
        get { return propulsionEffect; }
        set { propulsionEffect = value; }
    }

    public int HpRequired
    {
        get { return hpRequired; }
        set { hpRequired = value; }
    }

    public enum ModulePropulsions
    {
        SPEED,
        ACCELERATION,
        BOOST
    }
    private ModulePropulsions modulePropulsion;

    public ModulePropulsions ModulePropulsion
    {
        get { return modulePropulsion; }
        set { modulePropulsion = value; }
    }

}
