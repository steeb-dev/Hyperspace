// object info

using UnityEngine;
using System.Collections;

public class ObjectInformation {

    private string name;
    private string description;
    private Sprite icon;

    public ObjectInformation (string objName)
    {
        name = objName;
    }

    public ObjectInformation(string objName, string objDescripton)
    {
        name = objName;
        description = objDescripton;
    }

    public ObjectInformation(string objName, string objDescripton, string objIcon)
    {
        name = objName;
        description = objDescripton;
        icon = Resources.Load<Sprite>(objIcon);
    }

    public string ObjectName
    {
        get { return name; }
    }

    public string ObjectDescription
    {
        get { return description; }
    }

    public Sprite ObjectIcon
    {
        get { return icon; }
    }


}
