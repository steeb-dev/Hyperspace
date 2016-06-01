using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;  

public class SolarObjectPlanet : SolarObjectType
{ 
    public int minSize;    public int maxSize;
    public int minMass;    public int maxMass;

    public int mountPoint = 2;
    public int maxResource;
    public int planetGass;
    public int planetMineral;
    public int planetWater;

    private GravityInfluence m_GravityInfluence;

    public int MountPoint
    {
        get { return mountPoint; }
        set { mountPoint = value; }
    }

    public int MaxResource
    {
        get { return maxResource; }
        set { maxResource = value; }
    }

    public int PlanetGass
    {
        get { return planetGass; }
        set { planetGass = value; }
    }

    public int PlanetMineral
    {
        get { return planetMineral; }
        set { planetMineral = value; }
    }

    public int PlanetWater
    {
        get { return planetWater; }
        set { planetWater = value; }
    }

    public override void Initialise(System.Random random)
    {
        m_GravityInfluence = gameObject.GetComponent<GravityInfluence>();

        m_GravityInfluence.Mass = random.Next(minMass, maxMass);

        float newSize = (float)(minSize + (random.NextDouble() * maxSize));

        //m_GravityInfluence.transform.localScale = new Vector3(newSize, newSize, newSize);
    }
}
