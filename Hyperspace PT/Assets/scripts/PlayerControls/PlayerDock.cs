using UnityEngine;
using System.Collections;

public class PlayerDock : MonoBehaviour {
    private GameObject m_ObjectToDock;
    bool DockEnabled;

    public float radius = 2.0f;
    public float radiusSpeed = 0.5f;
    public float rotationSpeed = 80.0f;
    public Vector3 axis = Vector3.up;
    public Vector3 desiredPosition;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        InteractPlanet();
        if (DockEnabled)
        {
            Vector3 ObjectToDockPos = m_ObjectToDock.transform.position;
            transform.position = (transform.position - ObjectToDockPos).normalized * radius + ObjectToDockPos;
            transform.RotateAround(ObjectToDockPos, axis, rotationSpeed * Time.deltaTime);
            desiredPosition = (transform.position - ObjectToDockPos).normalized * radius + ObjectToDockPos;
            transform.position = Vector3.MoveTowards(transform.position, desiredPosition, Time.deltaTime * radiusSpeed);

            
        }
    }

    void InteractPlanet() {

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            if (hit.transform.tag == "DockableObject" && Input.GetMouseButtonDown(0))
            {
                DockEnabled = true;
                m_ObjectToDock = hit.transform.gameObject;
            }

            else {

            }
        }
    }
}


