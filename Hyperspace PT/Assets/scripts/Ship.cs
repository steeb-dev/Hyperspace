using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using UnityEngine;

public class Ship : MonoBehaviour
{
    public Rigidbody m_RigidBody;
    private GravityManager m_GravityManager;
    public float Mass;

    void Start()
    {
        m_GravityManager = FindObjectOfType<GravityManager>();
        
        //let's just deal with this at start considering theres no level load functionality yet
        m_GravityManager.UpdateGravityEffectors();
    }

    void Update()
    {
        Vector3 newPos = m_GravityManager.GetSummedGravityForceAtPosition(transform.position, Mass);
        this.m_RigidBody.AddForceAtPosition(newPos.normalized, transform.position); 

        //this.m_RigidBody.AddForceAtPosition(newPos.normalized, transform.position); 
    }
}

