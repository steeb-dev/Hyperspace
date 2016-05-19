using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;  

public class Star : SolarSystemObject 
{
    public int minSize;
    public int maxSize;
    public int minMass;
    public int maxMass;
    public Color[] possibleColors;

    private GravityInfluence m_GravityInfluence;
    
    public override void Initialise(System.Random random)
    {
        m_GravityInfluence = gameObject.GetComponent<GravityInfluence>();
        m_GravityInfluence.Mass = random.Next(minMass, maxMass);
        float newSize = (float)(minSize + (random.NextDouble() * maxSize));
        m_GravityInfluence.transform.localScale = new Vector3(newSize, newSize, newSize);
        int colorIndex = random.Next(0, possibleColors.Length);
        gameObject.GetComponent<MeshRenderer>().material.color = possibleColors[colorIndex];
    }

}
