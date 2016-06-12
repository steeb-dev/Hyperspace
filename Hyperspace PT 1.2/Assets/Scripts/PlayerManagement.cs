using UnityEngine;
using System.Collections;

public class PlayerManagement : MonoBehaviour {
    private GravityInfluence pmGI;
    private PlayerControls pmPC;
    private PlayerMovement pmPM;
    private ModuleUse pmMU;
    private GameObject ghostCraft;

    private PrefabLoader craftPrefab;



    // Use this for initialization
    void Awake () {

        pmGI = this.gameObject.AddComponent<GravityInfluence>();
        pmPC = this.gameObject.AddComponent<PlayerControls>();
        pmPM = this.gameObject.AddComponent<PlayerMovement>();

        ghostCraft = (GameObject)Instantiate(SpawnCraft(GameInformation.Craft));
        pmMU = ghostCraft.gameObject.AddComponent<ModuleUse>();
        ghostCraft.transform.name = GameInformation.PilotName + "'s Craft";

        pmGI.IsAffectedByGravity = true;
        pmGI.Mass = GameInformation.Craft.Mass;
        pmPM.power = GameInformation.Craft.Propulsion;

        SetPlayerUIName();
    }

    void Update()
    {
        ghostCraft.transform.position = this.transform.position;
    }

    public GameObject SpawnCraft(CraftClassType craft)
    {
        GameObject prefabFactory = GameObject.FindGameObjectWithTag("GameManager");
        craftPrefab = prefabFactory.GetComponent<PrefabLoader>();

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
    }

    public void SetPlayerUIName()
    {
        GameObject prefabFactory = GameObject.FindGameObjectWithTag("GameManager");
        craftPrefab = prefabFactory.GetComponent<PrefabLoader>();

        craftPrefab.pilotName.text = GameInformation.PilotName;
    }

}
