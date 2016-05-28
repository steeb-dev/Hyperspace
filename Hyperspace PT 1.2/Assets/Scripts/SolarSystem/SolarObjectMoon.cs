using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

public class SolarObjectMoon : SolarSystemType
{
    public int minSize; public int maxSize;
    public int minMass; public int maxMass;

    public int hardPoint;
    public int maxResource;
    public int moonGass;
    public int moonMineral;
    public int moonWater;

    private GravityInfluence m_GravityInfluence;

    public int HardPoint
    {
        get { return hardPoint; }
        set { hardPoint = value; }
    }

    public int MaxResource
    {
        get { return maxResource; }
        set { maxResource = value; }
    }

    public int MoonGass
    {
        get { return moonGass; }
        set { moonGass = value; }
    }

    public int MoonMineral
    {
        get { return moonMineral; }
        set { moonMineral = value; }
    }

    public int MoonWater
    {
        get { return MoonWater; }
        set { MoonWater = value; }
    }

    public override void Initialise(System.Random random)
    {
        m_GravityInfluence = gameObject.GetComponent<GravityInfluence>();

        m_GravityInfluence.Mass = random.Next(minMass, maxMass);

        float newSize = (float)(minSize + (random.NextDouble() * maxSize));

        //m_GravityInfluence.transform.localScale = new Vector3(newSize, newSize, newSize);
    }
}
