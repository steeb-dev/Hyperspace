using UnityEngine;
using System.Collections;

[System.Serializable]
public struct xzBounds
{
    public int xMin;
    public int xMax;
    public int zMin;
    public int zMax;
}

public class SolarSystemGenerator : MonoBehaviour {
    public SolarSystemObject[] StarPrefabs;
    public SolarSystemObject[] SolarSystemPrefabs;

    //xy bounds assuming min of 0
    public xzBounds planetBounds;
    public xzBounds starBounds;


    public int maxStars;
    public int maxObjects;
    private System.Random random;


    // Use this for initialization
    void Start()
    {
        random = new System.Random();

        for (int i = 0; i < maxObjects; i++)
        {
            int prefabIndex = random.Next(0, SolarSystemPrefabs.Length);
            SolarSystemObject newSolarSystemObject = (SolarSystemObject)Instantiate(SolarSystemPrefabs[prefabIndex]);
            newSolarSystemObject.transform.position = new Vector3(random.Next(planetBounds.xMin, planetBounds.xMax), 0, random.Next(planetBounds.zMin, planetBounds.zMax));
            newSolarSystemObject.Initialise(random);
        }

        for (int i = 0; i < maxStars; i++)
        {
            int prefabIndex = random.Next(0, StarPrefabs.Length);
            SolarSystemObject newSolarSystemObject = (SolarSystemObject)Instantiate(StarPrefabs[prefabIndex]);
            newSolarSystemObject.transform.position = new Vector3(random.Next(starBounds.xMin, starBounds.xMax), 0, random.Next(starBounds.zMin, starBounds.zMax));
            newSolarSystemObject.Initialise(random);
        }
    }

	// Update is called once per frame
	void Update () {
	
	}
}
