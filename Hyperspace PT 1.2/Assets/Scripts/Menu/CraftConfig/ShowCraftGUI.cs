using UnityEngine;
using System.Collections;

public class ShowCraftGUI {

    public int craftSelection;
    private string[] craftSelectionNames = new string[] { "Light", "Medium", "Heavy" };
    private string pilotName = "PilotName";
    public int sw = (Screen.width / 2) - 125;
    public int sh = (Screen.height / 2) - 125;

    public void ShowCraftSelections()
    {
        // A list of Craft + Information
        DisplayMainItems();
        craftSelection = GUI.SelectionGrid(new Rect(sw - 125, sh, 250, 250), craftSelection, craftSelectionNames, 1);
        GUI.Label(new Rect(sw + 150, sh, 300, 300), FindCraftDescription(craftSelection));
        GUI.Label(new Rect(sw + 150, sh + 100, 300, 300), FindCraftStats(craftSelection));
        pilotName = GUI.TextArea(new Rect(sw - 400, sh, 100, 25), pilotName);
        ChooseCraft(craftSelection);
    }

    public void DisplayMainItems()
    {
        GUI.Label(new Rect(sw -125, sh - 50, 100, 100), "Select a Craft");
        if (GUI.Button(new Rect(sw + 150, sh + 350, 50,50), "Next"))
            {
                ChooseCraft(craftSelection);
                CraftConfigGUI.currentState = CraftConfigGUI.ConfigStates.MODULECONFIG;
            }
    }

    public void ChooseCraft(int craftSelection)
    {
        if (craftSelection == 0)
        {
            GameInformation.Craft = new CraftClassLight();
            GameInformation.PilotName = pilotName;
        }
        else if (craftSelection == 1)
        {
            GameInformation.Craft = new CraftClassMedium();
            GameInformation.PilotName = pilotName;
        }
        else if (craftSelection == 2)
        {
            GameInformation.Craft = new CraftClassHeavy();
            GameInformation.PilotName = pilotName;
        }
    }

    private string FindCraftDescription (int craftSelection)
    {
        if (craftSelection == 0)
        {
            CraftClassType tempCraft = new CraftClassLight();
            return tempCraft.CraftDescription;
        }
        else if (craftSelection == 1)
        {
            CraftClassType tempCraft = new CraftClassMedium();
            return tempCraft.CraftDescription;
        }
        else if (craftSelection == 2)
        {
            CraftClassType tempCraft = new CraftClassHeavy();
            return tempCraft.CraftDescription;
        }
        return null;
    }

    private string FindCraftStats (int craftSelection)
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
}


