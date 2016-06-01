using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;  

public class SolarObjectStar : SolarObjectType
{
    public int minSize;    public int maxSize;
    public int minMass;    public int maxMass;

    private GravityInfluence m_GravityInfluence;
    
    public override void Initialise(System.Random random)
    {
        m_GravityInfluence = gameObject.GetComponent<GravityInfluence>();
        m_GravityInfluence.Mass = random.Next(minMass, maxMass);
        float newSize = (float)(minSize + (random.NextDouble() * maxSize));
        m_GravityInfluence.transform.localScale = new Vector3(newSize, newSize, newSize);
    }
}