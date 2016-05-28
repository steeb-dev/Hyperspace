using UnityEngine;
using System.Collections;

public class CraftClassLight : CraftClassType
{
    public CraftClassLight()
    {
        SpaceCraftName = "Light";
        Mass = 1;
        Propulsion = 500;
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