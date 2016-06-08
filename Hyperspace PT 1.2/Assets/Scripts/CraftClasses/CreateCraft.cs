/*
 * to customise and build ship from start of game or when player docks
 */


using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class CreateCraft : MonoBehaviour
{
    private CraftManager newCraft;

    public GameObject lightCraft;
    public GameObject mediumCraft;
    public GameObject heavyCraft;

    void Start()
    {
        newCraft = new CraftManager();
        newCraft.Craft = GameInformation.Craft;
        GameObject setCraft = (GameObject)Instantiate(SpawnCraft(GameInformation.Craft));
        setCraft.transform.name = GameInformation.PilotName;
        CreateNewPilot();
        SetCameraFollow(setCraft.transform);
        SaveInformation.SaveAllInformation();

    }

    public GameObject SpawnCraft(CraftClassType craft)
    {
        if (craft.SpaceCraftName == "Light")
            {
                return lightCraft;
            }
        if (craft.SpaceCraftName == "Medium")
            {
                return mediumCraft;
            }
        if (craft.SpaceCraftName == "Heavy")
            {
                return heavyCraft;
            }
        return null;
    }


    /*    
          private void StorePlayerInfo()
        {
            GameInformation.PilotName = newCraft.PilotName;
            GameInformation.Bounty = newCraft.Bounty;
            GameInformation.Energy = newCraft.Energy;
            GameInformation.EnergyRate = newCraft.EnergyRate;
            GameInformation.Power = newCraft.Power;
            GameInformation.Cargo = newCraft.Cargo;
            GameInformation.HCredit = newCraft.HCredit;
        }
    */
    private void CreateNewPilot()
    {
        newCraft.PilotName = GameInformation.PilotName;
        newCraft.Bounty = 0;
        newCraft.Energy = newCraft.Craft.MaxEnergy;
        newCraft.EnergyRate = newCraft.Craft.EnergyRechargeRate;
        newCraft.Power = newCraft.Craft.PowerGrid;
        newCraft.Cargo = newCraft.Craft.CargoHold;
        newCraft.HCredit = 100;
        

        Debug.Log("Pilot Name: " + newCraft.PilotName);
        Debug.Log("Bounty: " + newCraft.Bounty);
        Debug.Log("SpaceCraft: " + newCraft.Craft.SpaceCraftName);
        Debug.Log("Energy: " + newCraft.Energy);
        Debug.Log("Energy Rate: " + newCraft.EnergyRate);
        Debug.Log("Power Grid: " + newCraft.Power);
        Debug.Log("Cargo Hold: " + newCraft.Cargo);
    }

    void SetCameraFollow(Transform __target)
    {
        GameObject findCamera = GameObject.FindGameObjectWithTag("MainCamera");
        findCamera.GetComponent<CameraFollow>().target = __target;
    }
}
