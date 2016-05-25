using UnityEngine;
using System.Collections;

[System.Serializable]
public class PlayerFire : MonoBehaviour
{
    public GameObject shot;
    public Transform shotSpawn;
    public float fireRate;

    private float nextFire;

    void Update()
    {
        if ((Input.GetMouseButtonDown(0)) && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
        }
    }
}