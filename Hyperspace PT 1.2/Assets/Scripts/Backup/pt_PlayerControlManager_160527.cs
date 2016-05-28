/* Prototype Player Control Manager - On orbit player controls are unhooked from craft*/

using UnityEngine;

public class pt_PlayerControlManager_160527 : MonoBehaviour
{
    public float power = 500f;
    public float p;
    public Vector3 controlPosition;

    Vector3 thrustForward;
    Vector3 hitpoint;


    enum PlayerInControl { Active, Inactive }
    PlayerInControl incontrol = PlayerInControl.Active;

    Rigidbody spaceCraftRigidBody;          // Reference to the player's rigidbody.
    Collider orbitObject;


    void Awake()
    {
        spaceCraftRigidBody = GetComponent<Rigidbody>();
        incontrol = PlayerInControl.Active;
    }

    void Update()
    {

    }

    void FixedUpdate()
    {
        // Store the input axes.


        ControlOverRide(incontrol);
        ApplyThrustToTarget(p, hitpoint);
    }

    private Vector3 MouseCast()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        Physics.Raycast(ray, out hit);
        Vector3 mouseTarget = hit.point;
        return mouseTarget;
    }

    void ApplyThrustToTarget(float p, Vector3 __target)
    {
        __target.y = 0;
        thrustForward = __target - transform.position;
        thrustForward = (thrustForward.normalized * power * Time.deltaTime) * p;
        spaceCraftRigidBody.AddForce(thrustForward);
    }

    void ControlOverRide(PlayerInControl control)
    {
        switch (control)
        {
            case PlayerInControl.Active:
                Debug.Log("Active");
                p = Input.GetAxis("Vertical");
                hitpoint = MouseCast();
                break;
            case PlayerInControl.Inactive:
                Debug.Log("Inactive");
                p = .5f;
                hitpoint = controlPosition;
                break;
        }
    }


    void OnTriggerStay(Collider other)
    {
        if (other.tag == "OrbitField")
        {
            incontrol = PlayerInControl.Inactive;
            controlPosition = other.gameObject.transform.position;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "OrbitField")
        {
            incontrol = PlayerInControl.Active;
        }
    }


}