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
        this.ModuleAction.Add(new Ranged(100f));
       // this.ModuleAction.Add(new AreaOfEffect(1.5f, 1f, 50f));
       // this.ModuleAction.Add(new DamageOverTime(2f, 5f, 1f));
    }
}
