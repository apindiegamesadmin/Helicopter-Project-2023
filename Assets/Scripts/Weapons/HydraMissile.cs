using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HydraMissile : MonoBehaviour
{
    public float travelspeed;
    public Rigidbody _rigidbody;
    private Transform firePoint;
    public ParticleSystem fireball;

    private void Awake()
    {
        firePoint = GameObject.Find("FirePoint").transform;
        // fireball = Instantiate(fireball, transform.position + new Vector3(0, 0, -2.3f), transform.rotation);
    }

    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        _rigidbody.position += firePoint.forward * travelspeed * Time.deltaTime;
        fireball.transform.position = _rigidbody.position + new Vector3(0, 0, -2.3f);
        float timer = 5f;
        if (timer > 0)
        {
            timer -= Time.deltaTime;
        }
        else
        {
            Destroy(this.gameObject);
            Destroy(fireball);
        }
    }
}
