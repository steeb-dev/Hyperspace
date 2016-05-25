using UnityEngine;
using System.Collections;

public class PlayerManager : MonoBehaviour {
    public int EnergyRate = 2;
    public float FireRate = 1f;
    public int Q_Spell = 1;
    public int E_Spell = 1;
    public int Color = 0;

    [SerializeField]
    private PlayerStat energy;

    private void Awake()
    {
        energy.Initialize();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown (0))
        {
            energy.CurrentValue -= 25;
        }

        if (energy.CurrentValue < energy.MaxValue)
        {
            energy.CurrentValue += EnergyRate;
        }
    }

    // Use this for initialization

}
