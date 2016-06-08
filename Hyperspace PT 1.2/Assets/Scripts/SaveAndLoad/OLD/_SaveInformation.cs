using UnityEngine;
using System.Collections;

public class _SaveInformation {

    public static void SaveAllInformation()
    {
        PlayerPrefs.SetString("PILOTNAME", GameInformation.PilotName);
        PlayerPrefs.SetInt("BOUNTY", GameInformation.Bounty);
        PlayerPrefs.SetFloat("ENERGY", GameInformation.Energy);
        PlayerPrefs.SetFloat("ENERGYRATE", GameInformation.EnergyRate);
        PlayerPrefs.SetInt("POWER", GameInformation.Power);
        PlayerPrefs.SetInt("CARGO", GameInformation.Cargo);
        PlayerPrefs.SetInt("HCredit", GameInformation.HCredit);
      //  PPSerialization.Save("ClassType", GameInformation.Craft);
        //Serializer.Save<CraftClassType>("playercraft.ini", GameInformation.Craft);

        //   PlayerPrefs.SetString("CRAFT", GameInformation.Craft);




        Debug.Log("Saved");
    }
}
 