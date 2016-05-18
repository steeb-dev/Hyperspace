using UnityEngine;
using System.Collections;

public class GravityInfluence : MonoBehaviour 
{
	private Vector3 rescalegrav;

	public Vector3 newPosition;	// object position
	private Transform gravityPos;	// xurrent transform position.

	void OnTriggerEnter(Collider solarObject) {
	}

	void OnTriggerStay(Collider solarObject) {
		if (solarObject.attachedRigidbody)
		{
			//newPosition = Vector3.Lerp(solarObject.transform.position, transform.position, Time.deltaTime * 0.5f);
			newPosition = solarObject.transform.position - transform.position;
			newPosition = -newPosition;
			solarObject.attachedRigidbody.AddForceAtPosition(newPosition.normalized, transform.position); 
			Debug.Log (newPosition);
		}
			

	}

	void Start() {
		rescalegrav = new Vector3 (transform.localScale.x * 3, transform.localScale.y * 3, transform.localScale.z * 3);
		transform.localScale = rescalegrav;
	}

}