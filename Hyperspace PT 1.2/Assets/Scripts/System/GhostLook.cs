using UnityEngine;
using System.Collections;

public class GhostLook : MonoBehaviour {

    Vector3 gizmoPosition;

	void Update () {
       // this.gameObject.transform.rotation = new Quaternion(0,0,0,0);
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        Physics.Raycast(ray, out hit);
        Vector3 __target = hit.point;
       __target.y = 0;
        gizmoPosition = __target;
        transform.rotation = Quaternion.LookRotation(transform.position - __target);
    }

    void OnDrawGizmos()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawCube(gizmoPosition, new Vector3(1, 1, 1));
    }
}
