using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SpaceCraftTurretManager : MonoBehaviour {

    public int NumberOfTurrets = 0;
    public GameObject go_SpaceCraftToDock;
    public GameObject go_DockingTrigger;
    public List<CraftObjectTurret> TurrentManager = new List<CraftObjectTurret>();

    void Start () {
        TurrentManager.Clear();
        foreach (Transform child in transform)
        {
            if (child.tag == "Turret")
            {
                NumberOfTurrets++;
                TurrentManager.Add(new CraftObjectTurret(child.gameObject, false));
            }
        }
    }
	
	// Update is called once per frame
	void Update () {
    }

    public void DockingTrigger(GameObject SpaceCraftToDock)
    {
        go_SpaceCraftToDock = SpaceCraftToDock;
        go_DockingTrigger = this.transform.Find("DockingTrigger").gameObject;
    }
}
