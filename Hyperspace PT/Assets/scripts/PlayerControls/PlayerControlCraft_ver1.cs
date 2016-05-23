using UnityEngine;

public class PlayerControlCraft_ver1 : MonoBehaviour
{
	public float power = 500f;

	Vector3 movementForward; 
	Vector3 movementTurn;			// The vector to store the direction of the player's movement.
	Rigidbody shipRigidbody;          // Reference to the player's rigidbody.
//	int SpacePlane;                      // A layer mask so that a ray can be cast just at gameobjects on the floor layer.
//	float camRayLength = 100f;          // The length of the ray from the camera into the scene.


	void Awake ()
	{
		// Create a layer mask for the floor layer.
//		SpacePlane = LayerMask.GetMask ("SpacePlane");

		// Set up references.
		shipRigidbody = GetComponent <Rigidbody> ();
	}


	void FixedUpdate ()
	{
		// Store the input axes.
		float p = Input.GetAxis ("Vertical");

		// Move the player around the scene.
		Power (p);
	}

	void Power (float p)
	{
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit hit;
		Physics.Raycast(ray, out hit);
		Vector3 __target = hit.point;

		// Set the movement vector based on the axis input.
		movementForward.Set (0f, 0f,p);

		// Normalise the movement vector and make it proportional to the speed per second.
		movementForward = movementForward.normalized * power * Time.deltaTime;

		// Move the player to it's current position plus the movement.
		shipRigidbody.AddRelativeForce (movementForward);

		//shipRigidbody.AddTorque (movementTurn);
		transform.LookAt(__target);

	}

}