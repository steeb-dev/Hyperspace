using UnityEngine;
using System.Collections;

public class ShotMover : MonoBehaviour
{
    public GameObject pm_velocity;
    public float speed;

    void Start()
    {
        pm_velocity = GameObject.FindGameObjectWithTag("SpaceCraft");
        Vector3 v = transform.forward * speed;
        v += pm_velocity.GetComponent<Rigidbody>().velocity;
        GetComponent<Rigidbody>().velocity = v;
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "SpaceCraft")
        {
            //
        }
        else if (collision.collider.name == "Shot(Clone)") { }
        else { Destroy(gameObject); }

        Destroy(gameObject, 8f);
    }
}