using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Diagnostics;

public class ModuleIcons : MonoBehaviour
{
    private PrefabLoader modIcon;
    private Stopwatch moduleCooldownTimer;
    private Button button;
    private Image fillImage;
    private CraftModules loader;

    public void Awake()
    {
        modIcon = new PrefabLoader();
        SetIcons();
    }

    public void OnUseModule(CraftModules module, int uiPosition)
    {
       modIcon = GameObject.FindGameObjectWithTag("GameManager").GetComponent<PrefabLoader>();
       GameObject iconObject = modIcon.moduleIcons[uiPosition];

       fillImage = iconObject.transform.GetChild(0).gameObject.GetComponent<Image>();

       button = iconObject.GetComponent<Button>();
       button.interactable = false;
       fillImage.fillAmount = 1;
       moduleCooldownTimer = new Stopwatch();
       moduleCooldownTimer.Start();

       Job.make(SpinImage(module.ModuleCooldown), true);

    }

    private IEnumerator SpinImage(float cooldown)
    {
        while (moduleCooldownTimer.IsRunning && moduleCooldownTimer.Elapsed.TotalSeconds < .5f)
        {
            fillImage.fillAmount = ((float)moduleCooldownTimer.Elapsed.TotalSeconds / .5f);
            yield return null;
        }
        
        fillImage.fillAmount = 0;
        button.interactable = true;
        moduleCooldownTimer.Stop();
        moduleCooldownTimer.Reset();
        
        yield return null;
    }

    private void SetIcons()
    {
        modIcon = GameObject.FindGameObjectWithTag("GameManager").GetComponent<PrefabLoader>();
        GameObject iconObject = modIcon.moduleIcons[1];
        iconObject.GetComponent<Button>().image.sprite = GameInformation.Modules.ModuleInformation.ObjectIcon;
    }
}
