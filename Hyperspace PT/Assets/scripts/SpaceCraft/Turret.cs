using UnityEngine;
using System.Collections;

public class Turret
{
    public GameObject TurretObject;
    public bool TurretInUse;

    public Turret(GameObject newTurretObject, bool newTurretInUse)
    {
        TurretObject = newTurretObject;
        TurretInUse = newTurretInUse;
    }
}
