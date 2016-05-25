using System;
using System.Collections.Generic;
using UnityEngine;


public class GravityManager : MonoBehaviour
{
    public List<GravityInfluence> m_ActiveGravityInfluences = new List<GravityInfluence>();
    public float gravitational_constant = 10f;

    void Start()
    {
        UpdateGravityEffectors();
    }

    //Refresh collection of effectors
    public void UpdateGravityEffectors()
    {
        m_ActiveGravityInfluences.Clear();
        GravityInfluence[] activeEffectors = FindObjectsOfType<GravityInfluence>();
        foreach (GravityInfluence gi in activeEffectors)
        {
            if (gi.AffectsOthers)
            {
                m_ActiveGravityInfluences.Add(gi);
            }
        }
    }

    internal Vector3 GetSummedGravityForceAtPosition(object v, object objectPosition)
    {
        throw new NotImplementedException();
    }

    public Vector3 GetSummedGravityForceAtPosition(Vector3 objectPosition, float mass)
    {
        Vector3 finalForce = objectPosition * 0;
        foreach (GravityInfluence gi in m_ActiveGravityInfluences)
        {
            //if they're in the same spot ignore cos probably the same object
            if (gi.transform.position != objectPosition)
            {
                Vector3 addForce = gi.GetForceAtPosition(objectPosition, mass, gravitational_constant);
                finalForce += addForce;
            }
        }
        return finalForce;
    }


}