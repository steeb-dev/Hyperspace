using UnityEngine;
using System.Collections;

public class _LoadInformation {

    public static void _LoadAllInformation()
    {
        GameInformation.PilotName = PlayerPrefs.GetString("PILOTNAME");
        GameInformation.Bounty = PlayerPrefs.GetInt("BOUNTY");
        GameInformation.Energy = PlayerPrefs.GetFloat("ENERGY");
        GameInformation.EnergyRate = PlayerPrefs.GetFloat("ENERGYRATE");
        GameInformation.Power = PlayerPrefs.GetInt("POWER");
        GameInformation.Cargo = PlayerPrefs.GetInt("CARGO");
        GameInformation.HCredit = PlayerPrefs.GetInt("HCREDIT");

        if(PlayerPrefs.GetString("ELECTRONICMOD01") != null)
        {
    //        GameInformation.eModOne = (CraftModuleElectronics)PPSerialization.Load("ELECTRONICMOD01");
        }

        Debug.Log("Loaded");
    }
}