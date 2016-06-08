using UnityEngine;
using System.Collections;

[System.Serializable]
public class CraftClassHeavy : CraftClassType
{
   // private GameObject heavyCraft;

    public CraftClassHeavy()
    {
        SpaceCraftName = "Heavy";
        CraftDescription = "Most HardPoints, Biggest Hull";
        //   CraftPrefab = heavyCraft;
        Mass = 2f;
        Propulsion = 300;
        MaxEnergy = 1250;
        EnergyRechargeRate = .8f;
        PowerGrid = 20;
        CargoHold = 20;
        HardPointOffensive = 4;
        HardPointElectronic = 2;
        HardPointEngineering = 2;
        HardPointPropulsion = 2;
    }
}