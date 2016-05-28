using UnityEngine;
using System.Collections;

public class CraftClassMedium : CraftClassType
{
    public CraftClassMedium()
    {
        SpaceCraftName = "Medium";
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