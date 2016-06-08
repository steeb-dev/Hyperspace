//ranged

using UnityEngine;
using System.Collections;

public class Ranged : ModuleActions
{
    private const string abName = "Ranged";
    private const string abDescription = "a ranged attack";
    private const ActionTimes actionTime = ActionTimes.Start;

    private float lifeDistance;

    public Ranged(float lifeDist)
        : base(new ObjectInformation(abName, abDescription), actionTime)
    {
        lifeDistance = lifeDist;
    }

    public override void Action(GameObject playerObject, GameObject modulePrefab)
    {
        Job.make(CheckDistance(playerObject.transform.position, modulePrefab), true);
    }

    private IEnumerator CheckDistance(Vector3 startPosition, GameObject modulePrefab)
    {
        float tempDistance = Vector3.Distance(startPosition, modulePrefab.transform.position);
        while (tempDistance < lifeDistance)
        {
            tempDistance = Vector3.Distance(startPosition, modulePrefab.transform.position);
            yield return null;
        }
        //this.gameObject.SetActive(false);
       GameObject.Destroy(modulePrefab);

        yield return null;
    }
}
