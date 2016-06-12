using UnityEngine;
using System.Collections;

public class OffensiveMissle : CraftModules {

    private const string aName = "Missle";
    private const string aDescription = "Dumb-Fire Missle - Massive Damage";
    private const string aIcon = "modules/offensive/missledumb";
    private const ModuleTypes mType = ModuleTypes.OFFENSIVE;

    public OffensiveMissle () 
        : base(new ObjectInformation(aName, aDescription, aIcon))
    {
        ModuleCooldown = .5f;
        this.ModuleAction.Add(new Ranged(100f));
       // this.ModuleAction.Add(new AreaOfEffect(1.5f, 1f, 50f));
       // this.ModuleAction.Add(new DamageOverTime(2f, 5f, 1f));
    }
}
