using UnityEngine;
using System.Collections;
using System.Diagnostics;

public class Slow : ModuleActions
{
    private const string abName = "Slow";
    private const string abDescription = "Slows Movement Speed";
    private const ActionTimes actionTime = ActionTimes.End;

    private float effectDuration; //how long the effect to last
    private float dmgTickDuration;
    private float slowPercent;

    public Slow(float eD, float sP)
        : base(new ObjectInformation(abName, abDescription), actionTime)
    {
        effectDuration = eD;
        slowPercent = sP;
    }

    public override void Action(GameObject playerObject, GameObject objectHit)
    {
       // StartCoroutine(SlowMovement(objectHit));
    }

    private IEnumerator SlowMovement(GameObject objectHit)
    {

       // if (objectHit.GetComponent<"Movement">() != null)

        yield return new WaitForSeconds(effectDuration);

        yield return null;
    }
}

