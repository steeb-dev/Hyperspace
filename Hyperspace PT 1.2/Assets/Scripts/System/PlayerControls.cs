using UnityEngine;
using System.Collections;

public class PlayerControls : MonoBehaviour {
    private ModuleUse useMod;
    private CraftModules modSelected;
    private CraftManager setCraft;


    void Start()
    {
        useMod = new ModuleUse();
        //setCraft = new CraftManager();
        //modSelected = new OffensiveMissle();
        //setCraft.Module = modSelected;
    }

    void Update () {
	if(Input.GetKeyDown("e"))
        {
            useMod.EUse(this.gameObject);
        }
        if (Input.GetMouseButtonDown(0))
        {
            useMod.FUse(this.gameObject);
        }

    }
}
