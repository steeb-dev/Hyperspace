using UnityEngine;
using System.Collections;

public class BaseRawResource : BaseItem {

    public enum ResourceTypes
    {
        helium3,
        water,
        iron
    }

    private ResourceTypes resourceType;

    public ResourceTypes ResourceType
    {
        get
        {
            return resourceType;
        }

        set
        {
            resourceType = value;
        }
    }
}
