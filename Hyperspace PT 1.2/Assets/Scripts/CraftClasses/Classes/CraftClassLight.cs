using UnityEngine;
using System.Collections;

[System.Serializable]
public class CraftClassLight : CraftClassType
{
    //  private GameObject lightCraft;

    public CraftClassLight()
    {
        SpaceCraftName = "Light";
        CraftDescription = "Fast, Light and Agile";
        //    CraftPrefab = lightCraft;
        Mass = 1;
        Propulsion = 200;
        MaxEnergy = 800;
        EnergyRechargeRate = 1.1f;
        PowerGrid = 10;
        CargoHold = 10;
        HardPointOffensive = 2;
        HardPointElectronic = 1;
        HardPointEngineering = 1;
        HardPointPropulsion = 1;
    }
}