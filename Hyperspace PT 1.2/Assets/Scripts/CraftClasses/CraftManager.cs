using UnityEngine;
using System.Collections;

public class SpaceCraftManager : MonoBehaviour
{
    void Start()
    {
        CraftClassType craftTypeLight = new CraftClassLight();
        CraftClassType craftTypeMedium = new CraftClassMedium();
        CraftClassType craftTypeHeavy = new CraftClassHeavy();
    }
}
