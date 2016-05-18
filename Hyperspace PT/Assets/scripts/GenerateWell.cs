using UnityEngine;
using System.Collections;

public class GenerateWell : MonoBehaviour 
{
	public Terrain terrain;

	private TerrainData terrainData;

	void Awake()
	{
		terrainData = terrain.terrainData;
	}

	void Start()
	{
		EditTerrain ();
	}

	private void EditTerrain()
	{
		int heightmapWidth = 10; //terrainData.heightmapWidth;
		int heightmapHeight = 10; //terrainData.heightmapHeight;
		float[,] heights = terrainData.GetHeights (140, 140, heightmapWidth, heightmapHeight);

		for (int z = 0; z < heightmapHeight; z++) {
			for (int x = 0; x < heightmapWidth; x++) {
				float cos = Mathf.Cos (x);
				float sin = -Mathf.Sin (z);
				heights [x, z] = cos / 250 ;
			}
		}

		terrainData.SetHeights (140, 140, heights);
	}
}
