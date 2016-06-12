/*
 * to customise and build ship from start of game or when player docks
 */


using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.Networking;

public class CreateCraft : MonoBehaviour
{
    private CraftManager newCraft;
    private PrefabLoader craftPrefab;


    void Start()
    {

        newCraft = new CraftManager();

        craftPrefab = gameObject.GetComponent<PrefabLoader>();
        GameObject setCraft = (GameObject)Instantiate(craftPrefab.PlayerSphere);

        NetworkServer.Spawn(setCraft);

        CreateNewPilot();

        setCraft.transform.name = GameInformation.PilotName + "'s Cockpit" ;

        StorePlayerInfo();

        SetCameraFollow(setCraft.transform);

        SaveInformation.SaveAllInformation();
    }

   /* public GameObject SpawnCraft(CraftClassType craft)
    {
        craftPrefab = gameObject.GetComponent<PrefabLoader>();

        if (craft.SpaceCraftName == "Light")
            {
                return craftPrefab.spaceCraft[0];
        }
        if (craft.SpaceCraftName == "Medium")
            {
                return craftPrefab.spaceCraft[1];
        }
        if (craft.SpaceCraftName == "Heavy")
            {
                return craftPrefab.spaceCraft[2];
        }
        return null;
    }*/

      private void CreateNewPilot()
    {
        newCraft.Craft = GameInformation.Craft;
        newCraft.PilotName = GameInformation.PilotName;
        newCraft.Mass = newCraft.Craft.Mass;
        newCraft.Bounty = 0;
        newCraft.Energy = newCraft.Craft.MaxEnergy;
        newCraft.EnergyRate = newCraft.Craft.EnergyRechargeRate;
        newCraft.Power = newCraft.Craft.PowerGrid;
        newCraft.Cargo = newCraft.Craft.CargoHold;
        newCraft.HCredit = 100;
    }

    void SetCameraFollow(Transform __target)
    {
        GameObject findCamera = GameObject.FindGameObjectWithTag("MainCamera");
        findCamera.GetComponent<CameraFollow>().target = __target;
    }

    private void StorePlayerInfo()
    {
        GameInformation.Mass = newCraft.Craft.Mass;
        GameInformation.Bounty = newCraft.Bounty;
        GameInformation.Energy = newCraft.Energy;
        GameInformation.EnergyRate = newCraft.EnergyRate;
        GameInformation.Power = newCraft.Power;
        GameInformation.Cargo = newCraft.Cargo;
        GameInformation.HCredit = newCraft.HCredit;
    }
}
