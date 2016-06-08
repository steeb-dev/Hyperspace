using UnityEngine;
using System.Collections;

public class CraftConfigGUI : MonoBehaviour {

    public enum ConfigStates
    {
        CRAFTSELECT,
        MODULECONFIG
    }
    public static ConfigStates currentState;

    private ShowCraftGUI showFunctions = new ShowCraftGUI();
    private ShowModuleGUI showModules = new ShowModuleGUI();

    // Use this for initialization
    void Start () {
        currentState = ConfigStates.CRAFTSELECT;
	}
	
	// Update is called once per frame
	void Update () {

        switch (currentState)
        {
            case (ConfigStates.CRAFTSELECT):
                break;
            case (ConfigStates.MODULECONFIG):
                break;
        }
    }

    void OnGUI()
    {
        showFunctions.DisplayMainItems();
        if (currentState == ConfigStates.CRAFTSELECT)
            {
                showFunctions.ShowCraftSelections();
            }
        if (currentState == ConfigStates.MODULECONFIG)
            {
                showModules.ShowModuleSelections();
            }
        
    }
}
