using UnityEngine;
using System.Collections;

public class CraftConfigScript : MonoBehaviour {

	void Start () {
        LoadInformation.LoadAllInformation();
        Debug.Log("CraftConfigScript");
	}
}
