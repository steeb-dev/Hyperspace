using UnityEngine;
using System.Collections;
using System.Diagnostics;

public class DamageOverTime : ModuleActions
{
    private const string abName = "Damage Over Time";
    private const string abDescription = "A DOT";
    private const ActionTimes actionTime = ActionTimes.Start;

    private float effectDuration; //how long the effect to last
    private Stopwatch durationTimer = new Stopwatch();
    private float baseEffectDamage;
    private float dmgTickDuration;

    public DamageOverTime(float eD, float dmg, float dtd)
        : base(new ObjectInformation(abName, abDescription), actionTime)
    {
        effectDuration = eD;
        baseEffectDamage = dmg;
        dmgTickDuration = dtd;
    }

    public override void Action(GameObject playerObject, GameObject objectHit)
    {
       // StartCoroutine(DOT());
    }

    private IEnumerator DOT()
    {
        durationTimer.Start(); // Timer on

        while (durationTimer.Elapsed.TotalSeconds <= effectDuration)
        {
            yield return new WaitForSeconds(dmgTickDuration);
        }

        durationTimer.Stop();
        durationTimer.Reset();
        yield return null;
    }
}

