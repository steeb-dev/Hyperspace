using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class EnergyBar : MonoBehaviour {

    private float FillAmount;
    private float lerpSpeed = 4;

    [SerializeField]
    private Image BarL;
    [SerializeField]
    private Image BarR;
    [SerializeField]
    private Text ValueText;
    private Color storeColor;
    [SerializeField]
    private Color lowColor;


    public float MaxValue { get; set; }

    public float Value
    {
        set
        {
            //string[] tmp = ValueText.text.Split(':');
            ValueText.text = value.ToString();
            FillAmount = Map(value, 0, MaxValue, 0, 1);
        }
    }

    void Start () {
        storeColor = BarL.color;
    }
	
	void Update () {
        EnergyBarControl();
	}

    void EnergyBarControl()
    {
        if (FillAmount != BarL.fillAmount)
        {
            BarL.fillAmount = Mathf.Lerp(BarL.fillAmount, FillAmount, Time.deltaTime * lerpSpeed);
            BarR.fillAmount = Mathf.Lerp(BarR.fillAmount, FillAmount, Time.deltaTime * lerpSpeed);
        }
        
       if (FillAmount <= .5f)
        {
            BarL.color = Color.Lerp(lowColor, storeColor, FillAmount);
            BarR.color = Color.Lerp(lowColor, storeColor, FillAmount);
        }
        else if (FillAmount >= .5f)
        {
            BarL.color = storeColor;
            BarR.color = storeColor;
        }
    }
    private float Map(float value, float inMin, float inMax, float outMin, float outMax)
    {
        return (value - inMin) * (outMax - outMin) / (inMax - inMin) + outMin;
    }
}
