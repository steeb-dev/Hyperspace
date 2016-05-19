using UnityEngine;

public class GhostPlayerLook : MonoBehaviour
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