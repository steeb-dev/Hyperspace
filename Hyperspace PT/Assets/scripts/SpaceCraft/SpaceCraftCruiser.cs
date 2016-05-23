using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SpaceCraftCruiser : MonoBehaviour {

    public int NumberOfTurrets = 0;
   
    public bool InUse;

    public int CargoSpace = 10;

    public List<GameObject> TurretList = new List<GameObject>();

    // Use this for initialization
    void Start () {
        CheckTurrets();
	}
	
	// Update is called once per frame
	void Update () {
        Debug.Log(NumberOfTurrets);
	}

    void CheckTurrets()
    {
        TurretList.Clear();
        foreach (Transform child in transform)
        {
            if (child.tag == "Turret")
            {
                NumberOfTurrets++;
                TurretList.Add(child.gameObject);
            }
        }
    }
}
