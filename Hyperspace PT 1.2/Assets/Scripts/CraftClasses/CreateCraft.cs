/*
 * to customise and build ship from start of game or when player docks
 */


using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class CreateCraft : MonoBehaviour
{
    private CraftManager newCraft;
    private PrefabLoader craftPrefab;

    void Awake()
    {
        craftPrefab = gameObject.GetComponent<PrefabLoader>();
        GameObject setCockpit = (GameObject)Instantiate(craftPrefab.PlayerSphere);

        GameObject playerObject = new GameObject();
        setCockpit.transform.SetParent(playerObject.transform);
        newCraft = setCockpit.gameObject.AddComponent<CraftManager>();

        CreateNewPilot();

        playerObject.transform.name = GameInformation.PilotName;
        setCockpit.transform.name = GameInformation.PilotName + "'s Cockpit" ;

        StorePlayerInfo();
        SaveInformation.SaveAllInformation();
    }

      private void CreateNewPilot()
    {
        newCraft.Craft = GameInformation.Craft;
        newCraft.PilotName = GameInformation.PilotName;
        newCraft.Mass = newCraft.Craft.Mass;
        newCraft.Bounty = 0;
        newCraft.Energy = newCraft.Craft.MaxEnergy;
        newCraft.EnergyRate = newCraft.Craft.EnergyRechargeRate;
        newCraft.MaxEnergy = newCraft.Craft.MaxEnergy;
        newCraft.Power = newCraft.Craft.PowerGrid;
        newCraft.Propulsion = newCraft.Craft.Propulsion;
        newCraft.Cargo = newCraft.Craft.CargoHold;
        newCraft.HCredit = 100;
}

    private void StorePlayerInfo()
    {
        GameInformation.PilotName = newCraft.PilotName;
        GameInformation.Craft = newCraft.Craft;
        GameInformation.Mass = newCraft.Craft.Mass;
        GameInformation.Bounty = newCraft.Bounty;
        GameInformation.MaxEnergy = newCraft.MaxEnergy;
        GameInformation.Energy = newCraft.Energy;
        GameInformation.EnergyRate = newCraft.EnergyRate;
        GameInformation.Power = newCraft.Power;
        GameInformation.Cargo = newCraft.Cargo;
        GameInformation.HCredit = newCraft.HCredit;
    }
}
