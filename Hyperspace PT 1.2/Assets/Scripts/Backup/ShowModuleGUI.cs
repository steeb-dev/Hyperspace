using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine.SceneManagement;

public class ShowModuleGUI
{
    private int moduleSelection;
    private string[] moduleSelectionNames = new string[] { "null", "Missile" };
    public int sw = (Screen.width / 2) - 125;
    public int sh = (Screen.height / 2) - 125;

    public void ShowModuleSelections()
    {
        GUI.Label(new Rect(sw - 150, sh, 300, 300), "Select Offense Module");
        moduleSelection = GUI.SelectionGrid(new Rect(sw, sh, 250, 50), moduleSelection, moduleSelectionNames, 2);
        DrawSelectionIcon(moduleSelection);
        GUI.Label(new Rect(sw + 150, sh + 100, 300, 300), FindModuleInfo(moduleSelection));
        if (GUI.Button(new Rect(sw + 150, sh + 400, 50, 50), "End"))
        {
            if(moduleSelection == 1) {
                GameInformation.Modules = new OffensiveMissle();
                SaveInformation.SaveAllInformation();
                SceneManager.LoadScene("2_SolarSystem");
                Debug.Log("end");
            }
           
        }
    }

    private Sprite GetSelectionSprite(int moduleSelection)
    {
        if (moduleSelection == 0)
        {
            Sprite nullSprite = Resources.Load<Sprite>("modules/null");
            return nullSprite;
        }
        else if (moduleSelection == 1)
        {
            CraftModules modules = new OffensiveMissle();
            return modules.ModuleInformation.ObjectIcon;
        }
        return null;
    }

    private void DrawSelectionIcon(int moduleSelection)
    {
        Texture t = GetSelectionSprite(moduleSelection).texture;
        Rect tr = GetSelectionSprite(moduleSelection).textureRect;
        Rect r = new Rect(tr.x / t.width, tr.y / t.height, tr.width / t.width, tr.height / t.height);
        GUI.DrawTextureWithTexCoords(new Rect(sw, sh + 100, 64, 64), t, r);
    }

    private string FindModuleInfo(int moduleSelection)
    {
        if (moduleSelection == 0)
        {
            return null;
        }
        else if (moduleSelection == 1)
        {
            CraftModules modules = new OffensiveMissle();
            return modules.ModuleInformation.ObjectDescription;
        }
        return null;
    }
}



