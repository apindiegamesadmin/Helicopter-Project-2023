using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MachineGun : MonoBehaviour
{
    public ParticleSystem muzzle;
    public GameObject bulletPrefab;
    public Transform point;
    public float firePower = 100f;
    public float range = 100f;
    public float fireRate = 0f;

    void Start()
    {
        muzzle.Stop();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Y))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        muzzle.Play();
        RaycastHit hit;
        if (Physics.Raycast(point.position, point.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);


        }
    }
}
