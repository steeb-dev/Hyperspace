using UnityEngine;
using System.Collections;

public class PlayerManager : MonoBehaviour {
    public GameObject shot;
    public Transform shotSpawn;
    public int EnergyRate = 2;
    public float fireRate;

    private float nextFire;
    [SerializeField]
    private PlayerStat energy;



    private void Awake()
    {
        energy.Initialize();

    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0) || Input.GetMouseButton(0))
        {
            if(Time.time > nextFire && energy.CurrentValue > 26)
            { 
                nextFire = Time.time + fireRate;
                energy.CurrentValue -= 25;
                Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
            }
        }

        if (energy.CurrentValue < energy.MaxValue)
        {
            energy.CurrentValue += EnergyRate;
        }
    }

    // Use this for initialization

}
