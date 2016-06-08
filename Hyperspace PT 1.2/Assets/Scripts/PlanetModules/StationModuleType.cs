using UnityEngine;
using System.Collections;

public class StationModuleType : MonoBehaviour
{
    private string stationName;
    private string description;
    private int armor;
    private int platformSupplies;

    public string Name
    {
        get
        {
            return name;
        }

        set
        {
            name = value;
        }
    }

    public string Description
    {
        get
        {
            return description;
        }

        set
        {
            description = value;
        }
    }

    public int Armor
    {
        get
        {
            return armor;
        }

        set
        {
            armor = value;
        }
    }

    public int PlatformSupplies
    {
        get
        {
            return platformSupplies;
        }

        set
        {
            platformSupplies = value;
        }
    }

    public virtual void Initialise()
    {
        
    }

}
