using UnityEngine;
using System.Collections;

public class GravityInfluence : MonoBehaviour
{
    private Rigidbody m_RigidBody;
    public bool IsAffectedByGravity;
    public bool AffectsOthers;
    public float Mass;
        
    private GravityManager m_GravityManager;



    void Start()
    {
        m_GravityManager = FindObjectOfType<GravityManager>();
        m_RigidBody = gameObject.GetComponent<Rigidbody>();
    }


    void Update()
    {
        if (IsAffectedByGravity)
        {
            
            Vector3 newPos = m_GravityManager.GetSummedGravityForceAtPosition(transform.position, Mass);
            this.m_RigidBody.AddForceAtPosition(newPos.normalized, transform.position);
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

    void OnDrawGizmos()
    {
        Vector3 newPos2 = m_GravityManager.GetSummedGravityForceAtPosition(transform.position, Mass);
        Gizmos.color = new Color(1, 0, 0, 0.5F);
        Gizmos.DrawCube(newPos2, new Vector3(1, 1, 1));
    }
}

