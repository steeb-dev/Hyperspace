using UnityEngine;
using System.Collections;

[System.Serializable]
public class GameInformation : MonoBehaviour {

	void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }

    public static string PilotName { get; set; }
    public static int Bounty { get; set; }
    public static float Energy { get; set; }
    public static float EnergyRate { get; set; }
    public static int Power { get; set; }
    public static int Cargo { get; set; }
    public static CraftClassType Craft { get; set; }
    public static int HCredit { get; set; }
    public static CraftModules Modules { get; set; }

    //public static CraftModuleElectronics eModOne { get; set; }


}
