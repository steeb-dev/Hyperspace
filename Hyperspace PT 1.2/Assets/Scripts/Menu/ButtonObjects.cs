using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using System;

public class ButtonObjects : MonoBehaviour {
    private string buttonDown;
    private 

    void Update()
    {
        buttonDown = MouseCast();
        if (Input.GetMouseButtonDown(0) && buttonDown != null)
        {
            if (buttonDown == "Login")
            {
                SceneManager.LoadScene("1_CraftSetup");
            }
            if (buttonDown == "Exit")
            {
                Application.Quit();
            }
            if (buttonDown == "Next" && CraftConfigGUI.currentState == CraftConfigGUI.ConfigStates.CRAFTSELECT)
            {
                CraftConfigGUI.currentState = CraftConfigGUI.ConfigStates.MODULECONFIG;
            }
            if (buttonDown == "Next" && CraftConfigGUI.currentState == CraftConfigGUI.ConfigStates.MODULECONFIG)
            {
                Debug.Log("End");
            }
            if (buttonDown == "Back" && CraftConfigGUI.currentState == CraftConfigGUI.ConfigStates.CRAFTSELECT)
            {
                SceneManager.LoadScene("0_Main");
            }
            if (buttonDown == "Back" && CraftConfigGUI.currentState == CraftConfigGUI.ConfigStates.MODULECONFIG)
            {
                CraftConfigGUI.currentState = CraftConfigGUI.ConfigStates.CRAFTSELECT;
            }
        }
    }

    private string MouseCast()
    {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform.tag == "MenuItem")
                {
                    hit.transform.gameObject.GetComponent<ColorChange>().change = true;
                    return hit.transform.name;
                }
            }
            return null;
    }
}
