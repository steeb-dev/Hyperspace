using UnityEngine;
using System.Collections;


public class PlayerControlManager : MonoBehaviour
{
    public float power = 500f;
    private Vector3 controlPosition;
    


    Vector3 thrustForward;
    Vector3 orbit;
    Vector3 hitpoint;
    private Vector3 gizmoPosition = new Vector3(0,0,0);

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

    void OrbitAroundTarget(GameObject __target)
    {
        Vector3 velocity = spaceCraftRigidBody.velocity / 2;
        Vector3 newPos = transform.position + Quaternion.AngleAxis(10f, __target.transform.position) * velocity;

        gizmoPosition = newPos;

        float distance = Vector3.Distance(__target.transform.position, newPos);
        float distancedifference = (newPos - __target.transform.position).sqrMagnitude;
        float calc = (distance / distancedifference);
      
        newPos = (newPos * calc / 2);
       // Debug.Log("OrbitAroundTarget: newPos: " + newPos);

        newPos.y = 0;
        spaceCraftRigidBody.AddForce(newPos);
    }


    void OnTriggerStay(Collider other)
    {
        if (other.tag == "OrbitField")
        {
            OrbitAroundTarget(other.gameObject);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "OrbitField")
        {
        }
    }
    void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawCube(gizmoPosition, new Vector3(1, 1, 1));
    }
}