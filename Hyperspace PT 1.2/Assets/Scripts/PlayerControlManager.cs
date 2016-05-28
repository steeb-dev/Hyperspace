using UnityEngine;

public class PlayerControlManager : MonoBehaviour
{
    public float power = 500f;
    private Vector3 controlPosition;

    Vector3 thrustForward;
    Vector3 hitpoint;

    Rigidbody spaceCraftRigidBody;          // Reference to the player's rigidbody.
    Collider orbitObject;


    void Awake()
    {
        spaceCraftRigidBody = GetComponent<Rigidbody>();
    }

    void Update()
    {

    }

    void FixedUpdate()
    {
        float mouseP = Input.GetAxis("Vertical");
        hitpoint = MouseCast();
        ApplyThrustToTarget(mouseP, hitpoint);
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

    
    void OnTriggerStay(Collider other)
    {
        if (other.tag == "OrbitField")
        {
            float p = .1f;
            controlPosition = other.gameObject.transform.position;
            ApplyThrustToTarget(p, controlPosition);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "OrbitField")
        {
        }
    }


}