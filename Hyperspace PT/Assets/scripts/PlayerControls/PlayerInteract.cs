using UnityEngine;
using System.Collections;

public class PlayerInteract : MonoBehaviour {
    private GameObject go_ObjectToDock;
    GravityInfluence gi_ObjectToDock; // required to set orbit distance based on mass
    SpaceCraftTurretManager sctm_DockingTrigger;
    TurretControl tc_EnableTurret;

    bool b_DockSolarObject; //Planets
    bool b_DockObject; //SpaceCraft

    public float radius = 0;
    public float radiusSpeed = 0.5f;
    public float rotationSpeed = 1.0f;
    public Vector3 axis = Vector3.up;
    public Vector3 desiredPosition;

    // Use this for initialization
    void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))        {   MouseDown();    }
        if (b_DockSolarObject)      {   DockSolarObject();    }
        if (b_DockObject) { DockObject(); }
    }

    void MouseDown() {

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            if (hit.transform.tag == "DockableSolarObject" && !b_DockSolarObject) {
                go_ObjectToDock = hit.transform.gameObject; // define object that was clicked
                b_DockSolarObject = true;
            }
           // else if (hit.transform.tag == "DockableSolarObject" && b_DockSolarObject) { b_DockSolarObject = false;}

            if (hit.transform.tag == "DockableObject" && !b_DockObject)
            {
                go_ObjectToDock = hit.transform.gameObject; // define object that was clicked
                Debug.Log("Clicked Cruiser");
                //sctm_DockingTrigger.DockingTrigger(transform.gameObject); // send gameobject(playerobject) that wants to dock to SpaceCraftTurretManager DockingTrigger<>
                b_DockObject = true; // set that object is now docked
            }
            //else if (hit.transform.tag == "DockableObject" && b_DockObject) { b_DockObject = false; }
        }
       
    }

    void DockSolarObject() {
        Vector3 ObjectToDockPos = go_ObjectToDock.transform.position; // reference gameobject position

        gi_ObjectToDock = go_ObjectToDock.GetComponent<GravityInfluence>(); // reference GI to grab mass
        radius = gi_ObjectToDock.Mass * .5f; // set mass and radius

        transform.position = (transform.position - ObjectToDockPos).normalized * radius; // move player ship into orbit radius - lock ship in position - transform.position = (transform.position - ObjectToDockPos).normalized * radius + ObjectToDockPos;
        desiredPosition = ((transform.position - ObjectToDockPos).normalized * radius); // desiredPosition = ((transform.position - ObjectToDockPos).normalized * radius) + ObjectToDockPos;
        transform.position = Vector3.MoveTowards(transform.position, desiredPosition, Time.deltaTime * radiusSpeed);
        transform.RotateAround(ObjectToDockPos, axis, rotationSpeed * Time.deltaTime);
    }

    void DockObject()
    {
        sctm_DockingTrigger = go_ObjectToDock.GetComponent<SpaceCraftTurretManager>();

        int tn = sctm_DockingTrigger.NumberOfTurrets;
        int tmCount = sctm_DockingTrigger.TurrentManager.Count;
        
        if (tn >= tmCount && b_DockObject) // check array
        {
            GameObject Turret = sctm_DockingTrigger.TurrentManager[1].TurretObject;
            this.transform.parent = Turret.transform;
            tc_EnableTurret = Turret.GetComponent<TurretControl>();
            tc_EnableTurret.TurretEnabled = true;
            Destroy(this.gameObject);
        }

        // fill array position
        // store and delete player object
        // lock camera onto mountable position
        // load module ie. turret
    }
}


