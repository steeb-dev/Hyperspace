using UnityEngine;
using System.Collections;

public class PlayerInitialize : MonoBehaviour {

    private PrefabLoader craftPrefab;

    private GravityInfluence pmGI;
    private PlayerControls pmPC;
    private PlayerMovement pmPM;
    private ModuleUse pmMU;
    private CraftManager pmCM;
    
    private GameObject ghostCraft;

    private EnergyManager energy;

    void Awake () {
        //Add Componets to Cockpit / gravity, controls and movement
        pmGI = this.gameObject.AddComponent<GravityInfluence>();
        pmPM = this.gameObject.AddComponent<PlayerMovement>();
        pmPC = this.gameObject.AddComponent<PlayerControls>();

        //Instantiate type of craft to be attached to cockpit
        ghostCraft = (GameObject)Instantiate(SpawnCraft(GameInformation.Craft));

        //Attach modules to ghost craft
        pmMU = ghostCraft.gameObject.AddComponent<ModuleUse>();

        ghostCraft.transform.name = GameInformation.PilotName + "'s Craft";

        //Set component settings
        pmGI.IsAffectedByGravity = true;
        pmGI.Mass = GameInformation.Craft.Mass;
        pmPM.power = GameInformation.Craft.Propulsion;
        SetPlayerUIName();

    }

    void Start()
    {
        ghostCraft.transform.SetParent(this.transform.parent.transform);

        pmCM = this.gameObject.GetComponent<CraftManager>();
        energy = new EnergyManager();
        energy.Initialize(pmCM.MaxEnergy, pmCM.Energy);
    }

    void Update()
    {
        ghostCraft.transform.position = this.transform.position;
        EnergyManager();
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

    public void EnergyManager()
    {
        energy.CurrentValue = pmCM.Energy;
        if (pmCM.Energy < pmCM.MaxEnergy)
        {
            pmCM.Energy += pmCM.EnergyRate;
        }
    }
}
