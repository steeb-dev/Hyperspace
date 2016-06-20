using UnityEngine;
using System.Collections;
using System;

public class EnergyManager
{
    private EnergyBar eb; 
    private float maxValue;
    private float currentValue;

    public float CurrentValue
    {
        get
        {
            return currentValue;
        }

        set
        {
            currentValue = Mathf.Clamp(value, 0, MaxValue);
            eb.Value = currentValue;
        }
    }

    public float MaxValue
    {
        get
        {
            return maxValue;
        }

        set
        {
            maxValue = value;
            eb.MaxValue = maxValue;
        }
    }

    public void Initialize(float max, float current)
    {
        GameObject ebGO = GameObject.Find("EnergyBar");
        eb = ebGO.GetComponent<EnergyBar>();
        this.MaxValue = max;
        this.CurrentValue = current;
    }
}
