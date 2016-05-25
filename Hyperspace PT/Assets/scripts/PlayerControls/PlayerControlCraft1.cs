using UnityEngine;

public class PlayerControlCraft1 : MonoBehaviour
{
	public float power = 500f;

	Vector3 movementForward; 
	Vector3 movementTurn;			// The vector to store the direction of the player's movement.
	Rigidbody shipRigidbody;          // Reference to the player's rigidbody.


	void Awake ()
	{
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
        __target.y = 0;

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