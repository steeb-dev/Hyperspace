using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class SelectCraft : MonoBehaviour {
    private CraftClassType craftClass = new CraftClassLight();
    public int switchCraft;

    void Start () {
        switchCraft = 1;
        ChangeCraft();
    }

    void PrintData(CraftClassType craftClass)
    {
        Component[] objectlist = GetComponentsInChildren<Text>();
        foreach (Text item in objectlist)
        {
            CraftSelected(item, craftClass);
        }
    }

    void CraftSelected(Text item, CraftClassType craftClass)
    {
        if (item.transform.name == "sctData") { item.text = craftClass.SpaceCraftName; }
        else if (item.transform.name == "mData") { item.text = craftClass.Mass.ToString(); }
        else if (item.transform.name == "pData") { item.text = craftClass.Propulsion.ToString(); }
        else if (item.transform.name == "meData") { item.text = craftClass.MaxEnergy.ToString(); }
        else if (item.transform.name == "errData") { item.text = craftClass.EnergyRechargeRate.ToString(); }
        else if (item.transform.name == "pgData") { item.text = craftClass.PowerGrid.ToString(); }
        else if (item.transform.name == "chData") { item.text = craftClass.CargoHold.ToString(); }
        else if (item.transform.name == "ohpData") { item.text = craftClass.HardPointOffensive.ToString(); }
        else if (item.transform.name == "ehpData") { item.text = craftClass.HardPointElectronic.ToString(); }
        else if (item.transform.name == "proData") { item.text = craftClass.HardPointEngineering.ToString(); }
        else if (item.transform.name == "enghpData") { item.text = craftClass.HardPointPropulsion.ToString(); }
    }


    public void ChangeCraft()
    {
        Debug.Log(switchCraft);
        switch (switchCraft)
        {
            case 1:
                craftClass = new CraftClassLight();
                PrintData(craftClass);
                switchCraft = 2;
                break;
            case 2:
                craftClass = new CraftClassMedium();
                PrintData(craftClass);
                switchCraft = 3;
                break;
            case 3:
                craftClass = new CraftClassHeavy();
                PrintData(craftClass);
                switchCraft = 1;
                break;
        }
    }
}
