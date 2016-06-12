using UnityEngine;
using System.Collections;

public class ColorChange : MonoBehaviour {

    public Material mat;
    public bool change;

	// Use this for initialization
	void Start () {
        change = false;
	}
	
	// Update is called once per frame
	void Update () {
	    if (!change)
        {
            GetComponent<Renderer>().material.color = mat.color;
        }
	}
    
    void LateUpdate()
    {
        if (change)
        {
            GetComponent<Renderer>().material.color = new Color(1,1,1);
            change = false;
        }
    }
}
