using UnityEngine;
using System.Collections;
using System.Diagnostics;

[RequireComponent(typeof(SphereCollider))]
public class AreaOfEffect : ModuleActions
{
    private const string abName = "Area of Effect";
    private const string abDescription = "Area of Damage";
    private const ActionTimes actionTime = ActionTimes.End;

    private float areaRadius; //radius of collider
    private float effectDuration; //how long the effect to last
    private Stopwatch durationTimer = new Stopwatch();
    private float baseEffectDamage;
    private bool isOccupiued;
    private float dmgTickDuration;

    public AreaOfEffect(float aR, float eD, float dmg)
        : base(new ObjectInformation(abName, abDescription), actionTime)
    {
        areaRadius = aR;
        effectDuration = eD;
        baseEffectDamage = dmg;
        isOccupiued = false;
    }

    public override void Action(GameObject playerObject, GameObject objectHit)
    {
        //SphereCollider sc = this.gameObject.GetComponent<SphereCollider>();

       /* 
        * if (this.gameObject.GetComponent<SphereCollider>() == null)
                sc = this.gameObject.AddComponent<SphereCollider>();
        else
                sc = this.gameObject.GetComponent<SphereCollider>();
       */

        //sc.radius = areaRadius;
        //sc.isTrigger = true;

        //StartCoroutine(AOE());
    }

    private IEnumerator AOE()
    {
        durationTimer.Start(); // Timer on

        while (durationTimer.Elapsed.TotalSeconds <= effectDuration)
        {
            if(isOccupiued)
            {
                //dodamage
            }

            yield return new WaitForSeconds(dmgTickDuration);
        }

        durationTimer.Stop();
        durationTimer.Reset();
        yield return null;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (isOccupiued)
            {
                //do damage
            }
        else 
        isOccupiued = true;
    }

    private void OnTriggerExit(Collider other)
    {
        isOccupiued = false;
    }

}

