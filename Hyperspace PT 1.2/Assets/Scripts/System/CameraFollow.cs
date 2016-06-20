using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour
{
    public Transform target;

    void LateUpdate()
    {
        target = this.transform.parent.gameObject.transform;

        //float currentHeight = transform.position.y;

        transform.position = target.position;
        transform.position = new Vector3(transform.position.x, 50, transform.position.z);
        transform.LookAt(target);
    }
}