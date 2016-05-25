using UnityEngine;
using System.Collections;

public class ShotMover : MonoBehaviour
{
    public GameObject pm_velocity; 
    public float speed;

    void Start()
    {
        pm_velocity = GameObject.FindGameObjectWithTag("SpaceCraft");
       // Vector3 av = pm_velocity.GetComponent<Rigidbody>().velocity;
        //av = pm_velocity.transform.forward * speed;

        //GetComponent<Rigidbody>().AddRelativeForce(transform.forward * speed);
        // GetComponent<Rigidbody>().velocity = transform.forward * speed;

        Vector3 v = transform.forward * speed;
        v += pm_velocity.GetComponent<Rigidbody>().velocity;
        GetComponent<Rigidbody>().velocity = v;


    }
}