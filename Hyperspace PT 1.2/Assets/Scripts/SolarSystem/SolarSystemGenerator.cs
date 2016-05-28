using UnityEngine;
using System.Collections;
using LitJson;
using System.IO;

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
    public SolarSystemObject[] PlanetPrefabs;
    public SolarSystemObject[] MoonPrefabs;
  //  private SolarSystemObject solarSystemData = new SolarSystemObject();

    //xy bounds assuming min of 0
    public xzBounds starBounds;
    public xzBounds planetBounds;
    public xzBounds moonBounds;

    public int maxStars;
    public int maxPlanets;
    public int maxMoons;
    public string solarsystemName;

    private string jsonString;
    private JsonData ssData;
    private int ssItem;

    private System.Random random;

    void Awake()
    {
        random = new System.Random();
        GetSolarSystems();
    }

    void GetSolarSystems()
    {
        jsonString = File.ReadAllText(Application.dataPath + "/Scripts/SolarSystem/solarSystemNames.json");
        ssData = JsonMapper.ToObject(jsonString);
        ssItem = random.Next(0, 2);

        maxStars = (int)ssData["solarsystemnames"][ssItem]["stars"];
        maxPlanets = (int)ssData["solarsystemnames"][ssItem]["planets"];
        maxMoons = (int)ssData["solarsystemnames"][ssItem]["moons"];
        solarsystemName = (string)ssData["solarsystemnames"][ssItem]["systemname"];
        Debug.Log(maxStars);
        Debug.Log(maxPlanets);
        Debug.Log(maxMoons);
    }

    // Use this for initialization
    void Start()
    {
        for (int i = 0; i < maxStars; i++)
        {
            int prefabIndex = random.Next(0, StarPrefabs.Length);
            SolarSystemObject newSolarSystemObject = (SolarSystemObject)Instantiate(StarPrefabs[prefabIndex]);
            newSolarSystemObject.transform.name = solarsystemName + " " + "Star";
            newSolarSystemObject.transform.position = new Vector3(random.Next(starBounds.xMin, starBounds.xMax), 0, random.Next(starBounds.zMin, starBounds.zMax));
            newSolarSystemObject.Initialise(random);
        }

        for (int i = 0; i < maxPlanets; i++)
        {
            int prefabIndex = random.Next(0, PlanetPrefabs.Length);
            SolarSystemObject newSolarSystemObject = (SolarSystemObject)Instantiate(PlanetPrefabs[prefabIndex]);
            int romanNumber = i + 1;
            newSolarSystemObject.transform.name = solarsystemName + " " + romanNumber;
            newSolarSystemObject.transform.position = new Vector3(random.Next(planetBounds.xMin, planetBounds.xMax), 0, random.Next(planetBounds.zMin, planetBounds.zMax));

            //Set Parent
            GameObject[] findStar = GameObject.FindGameObjectsWithTag("SolarObjectStar");
            GameObject setParent = findStar[0];
            newSolarSystemObject.transform.SetParent(setParent.transform);

            newSolarSystemObject.Initialise(random);
        }

        for (int i = 0; i < maxMoons; i++)
        {
            int prefabIndex = random.Next(0, MoonPrefabs.Length);
            SolarSystemObject newSolarSystemObject = (SolarSystemObject)Instantiate(MoonPrefabs[prefabIndex]);

            //Find Parent
            GameObject[] findPlanets = GameObject.FindGameObjectsWithTag("SolarObjectPlanet");
            int getPlanetNumber = random.Next(0, findPlanets.Length);
            GameObject setParent = findPlanets[getPlanetNumber];
     
            //Position To Parent
            Vector3 setPosition = new Vector3(random.Next(moonBounds.xMin, moonBounds.xMax), 0, random.Next(moonBounds.zMin, moonBounds.zMax));
            newSolarSystemObject.transform.position = setParent.transform.position + setPosition;

            //Set Parent
            newSolarSystemObject.transform.SetParent(setParent.transform);

            //Initialise
            newSolarSystemObject.Initialise(random);
        }
    }
}
