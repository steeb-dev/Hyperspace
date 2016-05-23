using UnityEngine;
using System.Collections;

public class SolarObjectRotate : MonoBehaviour
{
    public float period;
    public int radius = 20;
    Vector3 ObjectToDockPos; // reference gameobject position

	void Update ()
	{
        OrbitParent();
	}

    void OrbitParent()
    {
        ObjectToDockPos = transform.parent.position;
        transform.RotateAround(ObjectToDockPos, Vector3.up, radius * Time.deltaTime);
    }
}

