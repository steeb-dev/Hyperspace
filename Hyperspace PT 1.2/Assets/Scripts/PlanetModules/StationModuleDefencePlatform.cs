using UnityEngine;
using System.Collections;

public class StationModuleDefencePlatform : StationModuleType
{
    private GameObject stationDefencePrefab;

    private int ironCollected;
    private int helium3Collected;
    private int waterCollected;

    public int IronCollected
    {
        get
        {
            return ironCollected;
        }

        set
        {
            ironCollected = value;
        }
    }

    public int Helium3Collected
    {
        get
        {
            return helium3Collected;
        }

        set
        {
            helium3Collected = value;
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
