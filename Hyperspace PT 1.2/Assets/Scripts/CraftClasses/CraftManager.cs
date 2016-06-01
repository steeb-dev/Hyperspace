using UnityEngine;
using System.Collections;

public class CraftManager : MonoBehaviour
{
    public CraftClassLight lightCraft;
    public CraftClassMedium mediumCraft;
    public CraftClassHeavy heavyCraft;
    GameObject findCamera;

    void Start()
    {
        CraftClassLight newCraft = (CraftClassLight)Instantiate(lightCraft);
        findCamera = GameObject.FindGameObjectWithTag("MainCamera");
        findCamera.GetComponent<CameraFollow>().target = newCraft.transform;
    }
}
