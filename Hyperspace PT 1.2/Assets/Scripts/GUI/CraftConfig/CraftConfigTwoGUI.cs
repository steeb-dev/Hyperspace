using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class CraftConfigTwoGUI : MonoBehaviour {

    public InputField pilotname;
    public Dropdown spacecraft;
    public Text craftinformation;
    public ToggleGroup offensivemodule;
    public Toggle[] offensivemoduletoggle;
    public Button spawn;
    public Image moduleselected;

    private Sprite nulltext;

    public void Start()
    {
        nulltext = moduleselected.sprite;

    }

    public void Update()
    {
        ChooseCraft();
        GetSelectionSprite();
    }

    private void ChooseCraft()
    {
        if (spacecraft.value == 0)
        {
            GameInformation.Craft = new CraftClassLight();
            craftinformation.text = FindCraftStats(spacecraft.value);
        }
        else if (spacecraft.value == 1)
        {
            GameInformation.Craft = new CraftClassMedium();
            craftinformation.text = FindCraftStats(spacecraft.value);
        }
        else if (spacecraft.value == 2)
        {
            GameInformation.Craft = new CraftClassHeavy();
            craftinformation.text = FindCraftStats(spacecraft.value);
        }
    }

    private string FindCraftStats(int craftSelection)
    {
        if (craftSelection == 0)
        {
            CraftClassType tempCraft = new CraftClassLight();
            string tempString =
            "Mass: " + tempCraft.Mass + "\n" +
            "Propulsion: " + tempCraft.Propulsion + "\n" +
            "Max Energy: " + tempCraft.MaxEnergy + "\n" +
            "Energy Recharge Rate: " + tempCraft.EnergyRechargeRate + "\n" +
            "Power Grid: " + tempCraft.PowerGrid + "\n" +
            "Cargo Hold: " + tempCraft.CargoHold + "\n" +
            "Offensive Hard Points : " + tempCraft.HardPointOffensive + "\n" +
            "Electronic Hard Points : " + tempCraft.HardPointElectronic + "\n" +
            "Engineering Hard Points : " + tempCraft.HardPointEngineering + "\n" +
            "Propulsion Hard Points : " + tempCraft.HardPointPropulsion + "\n";
            return tempString;
        }
        else if (craftSelection == 1)
        {
            CraftClassType tempCraft = new CraftClassMedium();
            string tempString =
            "Mass: " + tempCraft.Mass + "\n" +
            "Propulsion: " + tempCraft.Propulsion + "\n" +
            "Max Energy: " + tempCraft.MaxEnergy + "\n" +
            "Energy Recharge Rate: " + tempCraft.EnergyRechargeRate + "\n" +
            "Power Grid: " + tempCraft.PowerGrid + "\n" +
            "Cargo Hold: " + tempCraft.CargoHold + "\n" +
            "Offensive Hard Points : " + tempCraft.HardPointOffensive + "\n" +
            "Electronic Hard Points : " + tempCraft.HardPointElectronic + "\n" +
            "Engineering Hard Points : " + tempCraft.HardPointEngineering + "\n" +
            "Propulsion Hard Points : " + tempCraft.HardPointPropulsion + "\n";
            return tempString;
        }
        else if (craftSelection == 2)
        {
            CraftClassType tempCraft = new CraftClassHeavy();
            string tempString =
            "Mass: " + tempCraft.Mass + "\n" +
            "Propulsion: " + tempCraft.Propulsion + "\n" +
            "Max Energy: " + tempCraft.MaxEnergy + "\n" +
            "Energy Recharge Rate: " + tempCraft.EnergyRechargeRate + "\n" +
            "Power Grid: " + tempCraft.PowerGrid + "\n" +
            "Cargo Hold: " + tempCraft.CargoHold + "\n" +
            "Offensive Hard Points : " + tempCraft.HardPointOffensive + "\n" +
            "Electronic Hard Points : " + tempCraft.HardPointElectronic + "\n" +
            "Engineering Hard Points : " + tempCraft.HardPointEngineering + "\n" +
            "Propulsion Hard Points : " + tempCraft.HardPointPropulsion + "\n";
            return tempString;
        }
        return null;
    }

    public void SpawnPlayer()
    {
        string pilotInput = pilotname.text;
        GameInformation.PilotName = pilotInput; 
        SaveInformation.SaveAllInformation();
        SceneManager.LoadScene("2_SolarSystem");
    }

    private void GetSelectionSprite()
    {
        IEnumerator<Toggle> toggleEnum = offensivemodule.ActiveToggles().GetEnumerator();
        toggleEnum.MoveNext();

        Toggle toggle = toggleEnum.Current;

        if (toggle == offensivemoduletoggle[0])
          {
            CraftModules modules = new OffensiveMissle();
            GameInformation.Modules = modules;
            moduleselected.sprite = modules.ModuleInformation.ObjectIcon;
          }
        if (toggle == offensivemoduletoggle[1])
        {
            CraftModules modules = new OffensiveMissle();
            moduleselected.sprite = nulltext;
        }
        if (toggle == offensivemoduletoggle[2])
        {
            CraftModules modules = new OffensiveMissle();
            moduleselected.sprite = nulltext;
        }
        if (toggle == offensivemoduletoggle[3])
        {
            CraftModules modules = new OffensiveMissle();
            moduleselected.sprite = nulltext;
        }
    }

}
