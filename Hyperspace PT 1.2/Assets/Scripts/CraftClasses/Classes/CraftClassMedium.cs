using UnityEngine;
using System.Collections;

[System.Serializable]
public class CraftClassMedium : CraftClassType
{
 //   private GameObject mediumCraft;

    public CraftClassMedium()
    {
        SpaceCraftName = "Medium";
        CraftDescription = "Flexible, Best Speed/Power Ratio";
        //      CraftPrefab = mediumCraft;
        Mass = 1.5f;
        Propulsion = 400;
        MaxEnergy = 1000;
        EnergyRechargeRate = 1.0f;
        PowerGrid = 15;
        CargoHold = 15;
        HardPointOffensive = 3;
        HardPointElectronic = 1;
        HardPointEngineering = 1;
        HardPointPropulsion = 2;
    }
}