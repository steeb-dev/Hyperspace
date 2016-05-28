using UnityEngine;
using System.Collections;

public class ObjectRotate : MonoBehaviour
{
    public float speed = 1;
    Vector3 ObjectToDockPos; // reference gameobject position

	void Update ()
	{
        OrbitParent();
	}

    void OrbitParent()
    {
        ObjectToDockPos = transform.parent.position;
        transform.RotateAround(ObjectToDockPos, Vector3.up, speed * Time.deltaTime);
    }
}

