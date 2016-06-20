using UnityEngine;
using System.Collections;

public class ModuleUse : MonoBehaviour
{
    private OffensiveMissle om;
    private OffensiveEnergy eom;
    private ModuleIcons modIcon;
    private PrefabLoader modulePrefab;

    private CraftManager craft;


    public void Start()
    {
        craft = this.transform.parent.gameObject.GetComponentInChildren<CraftManager>();
    }

    public void BaseWeapon(GameObject craftOBJ)
    {
        //Module
        eom = new OffensiveEnergy();

        GameObject ghostModule = GameObject.Find("ModulePoint");
        GameObject go = Instantiate(GetModulePrefab(0), ghostModule.transform.position, ghostModule.transform.rotation) as GameObject;

        //Set instantiated object to module prefab
        eom.ModulePrefab = go;
        //Use module, set object to spawn from
        eom.UseModule(ghostModule.gameObject);
        //to be imported into module class
        SetVelocityAndDirection(ghostModule, craftOBJ, go, 15);

        craft.Energy -= eom.EnergyUse;

    }

    public void E(GameObject craftOBJ)
    {
        //Module
        om = new OffensiveMissle();

        GameObject ghostModule = GameObject.Find("ModulePoint");
        GameObject go = Instantiate(GetModulePrefab(1), ghostModule.transform.position, ghostModule.transform.rotation) as GameObject; 

        //Set instantiated object to module prefab
        om.ModulePrefab = go;
        //Use module, set object to spawn from
        om.UseModule(ghostModule.gameObject);
        //to be imported into module class
        SetVelocityAndDirection(ghostModule, craftOBJ, go, 15);

        craft.Energy -= om.EnergyUse;

        // Send module cooldown to iconslot
        setIcon(om, 1);
    }

    public GameObject GetModulePrefab(int modInt)
    {
        modulePrefab = GameObject.FindGameObjectWithTag("GameManager").GetComponent<PrefabLoader>();
        return modulePrefab.moduleObjects[modInt];
    }

    public void SetVelocityAndDirection(GameObject ghost, GameObject playersphere, GameObject moduleprefab, int vel)
    {
        Vector3 v = ghost.transform.forward * vel;
        v += playersphere.GetComponent<Rigidbody>().velocity;
        moduleprefab.GetComponent<Rigidbody>().velocity = v;
    }

    public void setIcon (CraftModules module, int icon)
    {
        modIcon = new ModuleIcons();
        modIcon.OnUseModule(module, icon);
    }
}