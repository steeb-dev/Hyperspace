using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;


public class SolarSystemType : SolarSystemObject
{
    private string id;
    private string systemName;
    private int stars;
    private int planets;

    public string Id
    {
        get { return id; }
        set { id = value; }
    }

    public string SystemName
    {
        get { return systemName; }
        set { systemName = value; }
    }

    public int Stars
    {
        get { return stars; }
        set { stars = value; }
    }

    public int Planets
    {
        get { return planets; }
        set { planets = value; }
    }
}
