/*
 * controls player settings and craft settings - SaveInformation, CreateCraft
 */

using UnityEngine;
using System.Collections;

[System.Serializable]
public class CraftManager : MonoBehaviour
{
    private string pilotName;
    private CraftClassType craft;
    private float mass;
    private int bounty;
    private float energy;
    private float energyRate;
    private float propulsion;
    private int power;
    private CraftModules module;
    private int hCredit; // hyper credit
    private int cargo;



    public string PilotName
    {
        get
        {
            return pilotName;
        }

        set
        {
            pilotName = value;
        }
    }

    public CraftClassType Craft
    {
        get
        {
            return craft;
        }

        set
        {
            craft = value;
        }
    }

    public int Bounty
    {
        get
        {
            return bounty;
        }

        set
        {
            bounty = value;
        }
    }

    public float Energy
    {
        get
        {
            return energy;
        }

        set
        {
            energy = value;
        }
    }

    public float EnergyRate
    {
        get
        {
            return energyRate;
        }

        set
        {
            energyRate = value;
        }
    }

    public int Power
    {
        get
        {
            return power;
        }

        set
        {
            power = value;
        }
    }

    public int Cargo
    {
        get
        {
            return cargo;
        }

        set
        {
            cargo = value;
        }
    }

    public int HCredit
    {
        get
        {
            return hCredit;
        }

        set
        {
            hCredit = value;
        }
    }

    public CraftModules Module
    {
        get
        {
            return module;
        }

        set
        {
            module = value;
        }
    }

    public float Mass
    {
        get
        {
            return mass;
        }

        set
        {
            mass = value;
        }
    }

    public float Propulsion
    {
        get
        {
            return propulsion;
        }

        set
        {
            propulsion = value;
        }
    }
}
