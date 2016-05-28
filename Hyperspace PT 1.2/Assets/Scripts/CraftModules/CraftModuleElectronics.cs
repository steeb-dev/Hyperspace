using UnityEngine;
using System.Collections;

public class CraftModuleElectronics : CraftModuleStatistics
{
    private int electronicEffect;
    private int hpRequired;

    public int ElectronicEffect
    {
        get { return electronicEffect; }
        set { electronicEffect = value; }
    }

    public int HpRequired
    {
        get { return hpRequired; }
        set { hpRequired = value; }
    }


    public enum ModuleElectronics
    {
        REPEAL,
        EMP,
        SHIELD,
        STEALTH
    }
    private ModuleElectronics moduleElectronic;

    public ModuleElectronics ModuleElectronic
    {
        get { return moduleElectronic; }
        set { moduleElectronic = value; }
    }

}
