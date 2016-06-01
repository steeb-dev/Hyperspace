using UnityEngine;
using System.Collections;

public class StationModuleDefencePlatform : StationModuleType
{
    private GameObject stationDefencePrefab;

    private int metalCollected;
    private int gasCollected;
    private int waterCollected;

    public int MetalCollected
    {
        get
        {
            return metalCollected;
        }

        set
        {
            metalCollected = value;
        }
    }

    public int GasCollected
    {
        get
        {
            return gasCollected;
        }

        set
        {
            gasCollected = value;
        }
    }

    public int WaterCollected
    {
        get
        {
            return waterCollected;
        }

        set
        {
            waterCollected = value;
        }
    }

    public override void Initialise()
    {
        stationDefencePrefab = gameObject.GetComponent<GameObject>();
    }

}
