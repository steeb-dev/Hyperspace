using System;
using System.Collections.Generic;
using UnityEngine;


public class GravityManager : MonoBehaviour
{
    public List<GravityEffector> m_ActiveGravityEffectors = new List<GravityEffector>();
    
    //Refresh collection of effectors
    public void UpdateGravityEffectors()
    {
        m_ActiveGravityEffectors.Clear();
        GravityEffector[] activeEffectors = FindObjectsOfType<GravityEffector>();
        foreach (GravityEffector ge in activeEffectors)
        {

            m_ActiveGravityEffectors.Add(ge);
        }
    }

    public Vector3 GetSummedGravityForceAtPosition(Vector3 objectPosition, float mass)
    {
        Vector3 finalForce = objectPosition;
        foreach (GravityEffector ge in m_ActiveGravityEffectors)
        {
            Vector3 addForce = ge.GetForceAtPosition(objectPosition, mass);
            finalForce += addForce;
        }
        return finalForce;
    }
}
