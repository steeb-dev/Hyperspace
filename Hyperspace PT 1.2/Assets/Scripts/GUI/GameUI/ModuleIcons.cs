using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Diagnostics;

public class ModuleIcons : MonoBehaviour
{
    public GameObject btn;
    private OffensiveMissle om;
    private Stopwatch moduleCooldownTimer;
    private Button button;
    private Image fillImage;

    float omCD;

    public void Awake()
    {
        om = new OffensiveMissle();
        omCD = om.ModuleCooldown;
    }

    public void OnUseModule()
    {
        fillImage = btn.transform.GetChild(0).gameObject.GetComponent<Image>();
        button = btn.GetComponent<Button>();
        button.interactable = false;
        fillImage.fillAmount = 1;
        moduleCooldownTimer = new Stopwatch();
        moduleCooldownTimer.Start();

        StartCoroutine(SpinImage());
    }

    private IEnumerator SpinImage()
    {
        while (moduleCooldownTimer.IsRunning && moduleCooldownTimer.Elapsed.TotalSeconds < omCD)
        {
            fillImage.fillAmount = ((float)moduleCooldownTimer.Elapsed.TotalSeconds / omCD);
            yield return null;
        }
        fillImage.fillAmount = 0;
        button.interactable = true;
        moduleCooldownTimer.Stop();
        moduleCooldownTimer.Reset();

        yield return null;
    }


}
