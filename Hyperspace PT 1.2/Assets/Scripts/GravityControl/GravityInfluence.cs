using UnityEngine;
using System.Collections;

public class GravityInfluence : MonoBehaviour
{
    private Rigidbody m_RigidBody;
    private GravityManager m_GravityManager;

    public bool IsAffectedByGravity;
    public bool AffectsOthers;
    public float Mass;

    void Start()
    {
        m_GravityManager = FindObjectOfType<GravityManager>();
        m_RigidBody = gameObject.GetComponent<Rigidbody>();
    }


    void Update()
    {
        if (IsAffectedByGravity)
        {
            Vector3 newPos = m_GravityManager.GetSummedGravityForceAtPosition(transform.position, Mass); //send summed forced object to be affected position and mass.
            float distance = Vector3.Distance(this.transform.position, newPos);
            Vector3 thrustForward = newPos - transform.position; // subtract summed from current position
           // distance = distance * 1.1f;
            thrustForward = (thrustForward.normalized * distance * Time.deltaTime);
            this.m_RigidBody.AddForce(thrustForward);
        }
    }


    public Vector3 GetForceAtPosition(Vector3 objectPosition, float objectMass, float gravitational_constant)
    {
        float distance_squared = (this.transform.position - objectPosition).sqrMagnitude;
        float force = gravitational_constant * ((this.Mass * objectMass) / distance_squared);

        // apply the force from the player toward the planet
        Vector3 force_direction = (this.transform.position - objectPosition).normalized;
        Vector3 force_vector = force_direction * force;

        return force_vector;
    }
}