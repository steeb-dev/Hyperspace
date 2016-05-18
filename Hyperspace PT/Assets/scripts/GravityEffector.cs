using UnityEngine;
using System.Collections;

public class GravityEffector : MonoBehaviour {

    public float size;
    public float mass;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public Vector3 GetForceAtPosition(Vector3 objectPosition, float objectMass)
    {
        //calculate force using the size mass relative to the object position
        float summedMass = mass + objectMass;

        float gravitational_constant = 100 ;
        float distance_squared = (this.transform.position - objectPosition).sqrMagnitude;

        float force = gravitational_constant * ((this.mass * objectMass) / distance_squared);
  
        // apply the force from the player toward the planet
        Vector3 force_direction = (this.transform.position - objectPosition).normalized;
        Vector3 force_vector = force_direction * force;

        return force_vector;
    }   

}
