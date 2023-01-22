using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hydra : MonoBehaviour
{
    public Transform MissilePrefab;
    public Transform SpawnPoint;
    public float fireDelta = 3F;
    private float nextFire = 0.5F;
    //private GameObject newProjectile;
    private float myTime = 0.0F;
    private GameObject MissleHolder;
    [HideInInspector] public bool IsAi, _Fire;
    // Start is called before the first frame update
    void Start()
    {
        MissleHolder = new GameObject("MissleParent");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        myTime = myTime + Time.deltaTime;
        _Fire = !IsAi ? Input.GetButton("Jump") : _Fire;
        if (_Fire && myTime > nextFire)
        {
            //print("blast");
            nextFire = myTime + fireDelta;
            //newProjectile = Instantiate(projectile, transform.position, transform.rotation) as GameObject;
            Transform newmissile = Instantiate(MissilePrefab, SpawnPoint.position, SpawnPoint.rotation);
            if (MissleHolder != null)
            {
                newmissile.transform.parent = MissleHolder.transform;
            }
            nextFire = nextFire - myTime;
            myTime = 0.0F;
        }
    }
}
