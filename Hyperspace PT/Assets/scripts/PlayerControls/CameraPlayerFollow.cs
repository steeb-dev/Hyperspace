using UnityEngine;
using System.Collections;

public class CameraPlayerFollow : MonoBehaviour
{
	public Transform target;

	void  LateUpdate ()
	{
		if (!target)
			return;

		float currentHeight = transform.position.y;

		transform.position = target.position;
		transform.position = new Vector3(transform.position.x, currentHeight, transform.position.z);
		transform.LookAt (target);
	}
}