using UnityEngine;
using System.Collections;

public class TurretControl : MonoBehaviour {
    public bool TurretEnabled = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	 if(TurretEnabled)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            Physics.Raycast(ray, out hit);
            Vector3 __target = hit.point;
            transform.LookAt(__target);
        }

	}
}
