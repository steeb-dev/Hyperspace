using UnityEngine;
using System.Collections;

public class GravityHeliosphere : MonoBehaviour {

    private GameObject go_SpaceCraft;
    private GameObject ParentStar;
    GravityInfluence star_GravityInfluence;
    GravityInfluence ship_GravityInfluence;


    // Use this for initialization
    void Start () {
        HelioVolume();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void HelioVolume()
    {
        ParentStar = transform.parent.gameObject;
        star_GravityInfluence = ParentStar.GetComponent<GravityInfluence>();
        float ParentMass = star_GravityInfluence.Mass;
        transform.localScale += ((transform.localScale * ParentMass) * 1.5f);
    }

    void OnTriggerExit(Collider SpaceCraft)
    {
        if (SpaceCraft.tag == "SpaceCraft")
        {
            ship_GravityInfluence = SpaceCraft.gameObject.GetComponent<GravityInfluence>();
            ship_GravityInfluence.IsAffectedByGravity = false;
        }
    }

    void OnTriggerStay(Collider SpaceCraft)  {
            if (SpaceCraft.tag == "SpaceCraft")
            {
                ship_GravityInfluence = SpaceCraft.gameObject.GetComponent<GravityInfluence>();
                ship_GravityInfluence.IsAffectedByGravity = true;
            }
        }
}
