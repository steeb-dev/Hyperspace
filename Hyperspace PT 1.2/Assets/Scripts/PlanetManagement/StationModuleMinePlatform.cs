using UnityEngine;
using System.Collections;

public class StationModuleMinePlatform : StationModuleType
{
    private GameObject stationMinePrefab;

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
        stationMinePrefab = gameObject.GetComponent<GameObject>();
    }

}
