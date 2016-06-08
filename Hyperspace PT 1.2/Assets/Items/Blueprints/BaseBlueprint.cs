using UnityEngine;
using System.Collections;

public class BaseBlueprint : BaseItem
{

    public enum BlueprintTypes
    {
        weaponsystem,
        electronicsystem,
        engineeringsystem,
        propulsionsystem,
        spacrcraft
    }

    private BlueprintTypes blueprintType;

    public BlueprintTypes BlueprintType
    {
        get
        {
            return blueprintType;
        }

        set
        {
            blueprintType = value;
        }
    }
}
