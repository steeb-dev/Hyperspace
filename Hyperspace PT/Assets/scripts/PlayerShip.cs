using UnityEngine;
using System.Collections;
using UnityEngine.UI;

[RequireComponent (typeof (CharacterController))]
public class PlayerShip : MonoBehaviour {

	public int shields;
	public int armor;
	public Text bountyText;

	public float rotationSpeed = 450;

	private int bounty;
	private Camera cam;
	private Quaternion targetRotation;

	float camRayLength = 100f;
	int MousePlane;



	void Start ()
	{
		bounty = 0;
		SetBountyText ();
		cam = Camera.main;
	}

	void Update() {
		TurnShip ();
	}


	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Pickup") 
		{
			Destroy(other.gameObject);
			bounty = bounty + 1;
			SetBountyText ();
		}
	}

	void SetBountyText ()
	{
		bountyText.text = bounty.ToString ();
	}

	void TurnShip ()
	{
		Vector3 mousePos = Input.mousePosition;
		mousePos = cam.ScreenToWorldPoint(new Vector3(mousePos.x,mousePos.y,cam.transform.position.y - transform.position.y));
		targetRotation = Quaternion.LookRotation(mousePos - new Vector3(transform.position.x,0,transform.position.z));
		transform.eulerAngles = Vector3.up * Mathf.MoveTowardsAngle(transform.eulerAngles.y,targetRotation.eulerAngles.y,rotationSpeed * Time.deltaTime);
	}

}











