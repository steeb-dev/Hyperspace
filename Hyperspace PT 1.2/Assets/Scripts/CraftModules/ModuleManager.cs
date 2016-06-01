using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ModuleManager : MonoBehaviour
{

    private CraftModuleOffensive newOffensiveModule;
    private string[] offensiveModuleName = new string[4] { "a", "b", "c", "d" };

    void Start()
    {
        CreateModuleOffensive();
        Debug.Log(newOffensiveModule.ModuleName);
    }

    public void CreateModuleOffensive()
    {
        newOffensiveModule = new CraftModuleOffensive();
        newOffensiveModule.ModuleName = offensiveModuleName[Random.Range(0,3)];
        newOffensiveModule.ModuleDescription = "This is a New Module Offense";
        newOffensiveModule.ModuleID = Random.Range(1, 101);
        newOffensiveModule.EnergyRequiredOnUse = 0;
        newOffensiveModule.MountPointRequired = 0;
        newOffensiveModule.PowerUsage = 0;
        newOffensiveModule.WeaponEffect = 1;
        newOffensiveModule.HpRequired = 1;
        newOffensiveModule.RegRequired = false;
        newOffensiveModule.PlayerControlled = false;
        ChooseOffensiveModuleType();
    }

    private void ChooseOffensiveModuleType()
    {
        int randontmp = Random.Range(1, 3);
        if (randontmp == 1)
        {
            newOffensiveModule.ModuleWeapon = CraftModuleOffensive.ModuleWeapons.ENERGY;
        }
        else if (randontmp == 2)
        {
            newOffensiveModule.ModuleWeapon = CraftModuleOffensive.ModuleWeapons.PROJECTILE;
        }
        else if (randontmp == 3)
        {
            newOffensiveModule.ModuleWeapon = CraftModuleOffensive.ModuleWeapons.MISSLE;
        }
    }
}
