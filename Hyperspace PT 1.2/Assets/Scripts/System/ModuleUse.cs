using UnityEngine;
using System.Collections;

public class ModuleUse : MonoBehaviour
{
    private OffensiveMissle om;
    private OffensiveEnergy eom;
    private PrefabLoader modulePrefab;
    private GameObject prefabFactory;

    private GameObject button;
    private ModuleIcons icon;

    public void Awake()
    {
        
    }

    public void EUse(GameObject craftOBJ)
    {
        

        prefabFactory = GameObject.FindGameObjectWithTag("GameManager");
        modulePrefab = prefabFactory.GetComponent<PrefabLoader>();

        GameObject ghost = GameObject.Find("ModulePoint");
       
        GameObject go = Instantiate(modulePrefab.moduleObjects[0], ghost.transform.position, ghost.transform.rotation) as GameObject;

        Vector3 v = ghost.transform.forward * 15;
        v += craftOBJ.GetComponent<Rigidbody>().velocity;
        go.GetComponent<Rigidbody>().velocity = v;

        om = new OffensiveMissle();
        om.ModulePrefab = go;
        om.UseModule(ghost.gameObject);

        prefabFactory = GameObject.Find("EButton");
        icon = prefabFactory.GetComponent<ModuleIcons>();
        icon.OnUseModule();

    }

    public void FUse(GameObject craftOBJ)
    {
        prefabFactory = GameObject.FindGameObjectWithTag("GameManager");
        modulePrefab = prefabFactory.GetComponent<PrefabLoader>();

        GameObject ghost = GameObject.Find("ModulePoint");


        GameObject go = Instantiate(modulePrefab.moduleObjects[1], ghost.transform.position, ghost.transform.rotation) as GameObject;

        Vector3 v = ghost.transform.forward * 15;
        v += craftOBJ.GetComponent<Rigidbody>().velocity;
        go.GetComponent<Rigidbody>().velocity = v;

        eom = new OffensiveEnergy();
        eom.ModulePrefab = go;
        eom.UseModule(ghost.gameObject);

    }
}