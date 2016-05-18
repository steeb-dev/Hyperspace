using UnityEngine;
using System.Collections;

public class SystemRotate : MonoBehaviour
{
	public Vector3 axis;
	public float period;


	// Use this for initialization
	void Start ()
	{
		axis = axis.normalized;
	}
	
	// Update is called once per frame
	void Update ()
	{
		transform.Rotate(axis, 360 * Time.deltaTime / period);

	}
}
