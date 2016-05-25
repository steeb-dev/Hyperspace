using UnityEngine;
using System.Collections;

public class CraftObjectTurret
{
    public GameObject TurretObject;
    public bool TurretInUse;

    public CraftObjectTurret(GameObject newTurretObject, bool newTurretInUse)
    {
        TurretObject = newTurretObject;
        TurretInUse = newTurretInUse;
    }
}
