using UnityEngine;
using System.Collections;

public class OffensiveEnergy : CraftModules {

    private const string aName = "Energy Bullet";
    private const string aDescription = "Small - Minor Damage";
    private const string aIcon = "modules/offensive/weaponenergy";
    private const ModuleTypes mType = ModuleTypes.OFFENSIVE;

    public OffensiveEnergy() 
        : base(new ObjectInformation(aName, aDescription, aIcon))
    {
        EnergyUse = 20;
        this.ModuleAction.Add(new Ranged(100f, 15));
    }
}
