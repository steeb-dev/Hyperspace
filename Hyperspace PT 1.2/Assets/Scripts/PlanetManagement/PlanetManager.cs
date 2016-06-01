using UnityEngine;
using System.Collections.Generic;
using System;

public class PlanetManager : MonoBehaviour {

    public StationModuleDefencePlatform defStation;
    public StationModuleTradePlatform tradeStation;
    public StationModuleMinePlatform mineStation;
    private StationModuleType setStation;
    private SolarObjectPlanet planetMountPoint;
    private List<GameObject> stationsInOrbit;
    private int prefabIndex = 0;
    public float orbittime = .5f;
    int mp;

    // Use this for initialization
    void Start () {
        stationsInOrbit = new List<GameObject>();
        mp = 1;
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
            {
                GameObject getGameObject = MouseCast();
                if (getGameObject.transform.position == this.gameObject.transform.position)
                    {
                        planetInteraction();
                    }
            }

        foreach (GameObject go in stationsInOrbit)
            {
                go.transform.RotateAround(this.transform.position, new Vector3 (.1f,1,-1f), (orbittime * Time.deltaTime) / 3);
            }
    }

    private GameObject MouseCast()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        Physics.Raycast(ray, out hit);
        GameObject mouseTarget = hit.collider.gameObject;
        return mouseTarget;
    }

    private void planetInteraction()
    {
        SolarObjectPlanet planetMountPoint = GetComponent<SolarObjectPlanet>();
        StationModuleDefencePlatform newStationObject = defStation;
       // StationModuleType setStation = new StationModuleType();

        if ( mp <= planetMountPoint.mountPoint)
        {
            mp++;
            newStationObject = (StationModuleDefencePlatform)Instantiate(newStationObject);
            newStationObject.transform.SetParent(this.transform);
            stationsInOrbit.Add(newStationObject.gameObject);
        }
    }
}

