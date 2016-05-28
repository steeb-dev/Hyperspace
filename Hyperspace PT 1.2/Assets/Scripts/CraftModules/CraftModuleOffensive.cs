using UnityEngine;
using System.Collections;

public class CraftModuleOffensive : CraftModuleStatistics
{
    private int weaponEffect;
    private int hpRequired;
    private bool regRequired;
    private bool playerControlled;

    public int WeaponEffect
    {
        get { return weaponEffect; }
        set { weaponEffect = value; }
    }

    public int HpRequired
    {
        get { return hpRequired; }
        set { hpRequired = value; }
    }

    public bool RegRequired
    {
        get { return regRequired; }
        set { regRequired = value; }
    }

    public bool PlayerControlled
    {
        get { return playerControlled; }
        set { playerControlled = value; }
    }

    public enum ModuleWeapons
    {
        ENERGY,
        PROJECTILE,
        MISSLE,
        MININGLASER,
        TURRET
    }
    private ModuleWeapons moduleWeapon;

    public ModuleWeapons ModuleWeapon
    {
        get { return moduleWeapon; }
        set { moduleWeapon = value; }
    }

}
