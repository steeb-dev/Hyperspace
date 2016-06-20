//ranged

using UnityEngine;
using System.Collections;

public class Ranged : ModuleActions
{
    private const string abName = "Ranged";
    private const string abDescription = "a ranged attack";
    private const ActionTimes actionTime = ActionTimes.Start;
    private float objectVelocity;
    private float objectRange;

    public Ranged(float range, float velocity)
        : base(new ObjectInformation(abName, abDescription), actionTime)
    {
        objectRange = range;
        objectVelocity = velocity;
    }

    public override void Action(GameObject playerObject, GameObject modulePrefab)
    {
        Job.make(CheckDistance(playerObject.transform.position, modulePrefab), true);
    }

    private IEnumerator CheckDistance(Vector3 startPosition, GameObject modulePrefab)
    {
        float tempDistance = Vector3.Distance(startPosition, modulePrefab.transform.position);
        while (tempDistance < objectRange)
        {
            tempDistance = Vector3.Distance(startPosition, modulePrefab.transform.position);
            yield return null;
        }
       GameObject.Destroy(modulePrefab);

        yield return null;
    }
}
