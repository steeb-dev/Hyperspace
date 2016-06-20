using UnityEngine;
using System.Collections;

public class SystemInitialize : MonoBehaviour {

    void Awake()
    {
        LoadInformation.LoadAllInformation();
    }
}
