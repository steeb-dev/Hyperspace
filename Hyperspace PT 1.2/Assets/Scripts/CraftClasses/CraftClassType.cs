using UnityEngine;
using System.Collections;

public class CraftClassType
{
    private string spaceCraftName;
    private float mass;
    private float propulsion;
    private float maxEnergy;
    private float energyRechargeRate;
    private int powerGrid;
    private int cargoHold;
    private int hardPointOffensive;
    private int hardPointElectronic;
    private int hardPointEngineering;
    private int hardPointPropulsion;

    public string SpaceCraftName
    {
        get { return spaceCraftName; }
        set { spaceCraftName = value; }
    }
        public float Mass {
        get { return mass; }
        set { mass = value; }
    }
    public float MaxEnergy
    {
        get { return maxEnergy; }
        set { maxEnergy = value; }
    }
    public float Propulsion {
        get { return propulsion; }
        set { propulsion = value; }
    }
    public float EnergyRechargeRate
    {
        get { return energyRechargeRate; }
        set { energyRechargeRate = value; }
    }
    public int PowerGrid
    {
        get { return powerGrid; }
        set { powerGrid = value; }
    }
    public int CargoHold
    {
        get { return cargoHold; }
        set { cargoHold = value; }
    }
    public int HardPointOffensive
    {
        get { return hardPointOffensive; }
        set { hardPointOffensive = value; }
    }
    public int HardPointElectronic
    {
        get { return hardPointElectronic; }
        set { hardPointElectronic = value; }
    }
    public int HardPointEngineering
    {
        get { return hardPointEngineering; }
        set { hardPointEngineering = value; }
    }
    public int HardPointPropulsion
    {
        get { return hardPointPropulsion; }
        set { hardPointPropulsion = value; }
    }

}