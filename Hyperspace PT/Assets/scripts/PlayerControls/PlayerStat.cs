using UnityEngine;
using System.Collections;
using System;

[Serializable]
public class PlayerStat {

    [SerializeField]
    private EnergyBar eb;
    [SerializeField]
    private float maxValue;
    [SerializeField]
    private float currentValue;

    public float CurrentValue
    {
        get
        {
            return currentValue;
        }

        set
        {
            currentValue = Mathf.Clamp(value,0,MaxValue);
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

    public void Initialize()
    {
        this.MaxValue = maxValue;
        this.CurrentValue = currentValue;
    }
}
