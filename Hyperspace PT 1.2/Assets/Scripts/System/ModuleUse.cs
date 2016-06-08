using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Diagnostics;

public class ModuleUse : MonoBehaviour {

    public GameObject offensiveMisslePrefab;
    private OffensiveMissle om;
    private Stopwatch moduleCooldownTimer;
    private Button button;
    private Image fillImage;

    public void OnModuleUse(GameObject btn)
    {
        fillImage = btn.transform.GetChild(0).gameObject.GetComponent<Image>();
        button = btn.GetComponent<Button>();
        button.interactable = false;
        fillImage.fillAmount = 1;
        moduleCooldownTimer = new Stopwatch();
        moduleCooldownTimer.Start();
        

        GameObject go = Instantiate<GameObject>(offensiveMisslePrefab);
        go.transform.position = this.transform.position;
        om = new OffensiveMissle();
        om.ModulePrefab = go;
        om.UseModule(this.gameObject);

        StartCoroutine(SpinImage());
    }

    private IEnumerator SpinImage()
    {
        while (moduleCooldownTimer.IsRunning && moduleCooldownTimer.Elapsed.TotalSeconds < om.ModuleCooldown)
        {
            fillImage.fillAmount = ((float)moduleCooldownTimer.Elapsed.TotalSeconds / om.ModuleCooldown);
            yield return null;
        }
        fillImage.fillAmount = 0;
        button.interactable = true;
        moduleCooldownTimer.Stop();
        moduleCooldownTimer.Reset();

        yield return null;
    }
}
