using UnityEngine;

public class GhostMouseLook : MonoBehaviour // not in use atm
{

    void Awake()
    {

    }


    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        Physics.Raycast(ray, out hit);
        Vector3 __target = hit.point;
        __target.y = 0;
        transform.LookAt(__target);
    }

}