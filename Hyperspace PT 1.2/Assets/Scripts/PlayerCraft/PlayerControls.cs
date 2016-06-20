using UnityEngine;
using System.Collections;

public class PlayerControls : MonoBehaviour {
    private ModuleUse useModule;


    void Start()
    {
        useModule = this.transform.parent.gameObject.GetComponentInChildren<ModuleUse>();
    }

    void Update () {
        if (Input.GetMouseButtonDown(0) || Input.GetMouseButton(0))
        {
            useModule.BaseWeapon(this.gameObject);

        }
        if (Input.GetKeyDown("e"))
        {
            useModule.E(this.gameObject);
        }
    }
}
