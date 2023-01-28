using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HydraMissile : MonoBehaviour
{
    public float travelspeed;
    public Rigidbody _rigidbody;
    private Transform firePoint;
    public ParticleSystem fireball;
    public const string ENEMY = "Enemy";
    private float timer = 5f;

    private void Awake()
    {
        firePoint = GameObject.Find("FirePoint").transform;
        // fireball = Instantiate(fireball, transform.position + new Vector3(0, 0, -2.3f), transform.rotation);
    }

    void Start()
    {
        _rigidbody.position += firePoint.forward * travelspeed * Time.deltaTime;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        _rigidbody.position += transform.forward * travelspeed * Time.deltaTime;
        fireball.transform.position = _rigidbody.position + new Vector3(0, 0, -2f);
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == ENEMY)
        {
            // Play explosion effect and sound

            // Take damage
            Damage damage = collision.transform.GetComponent<Damage>();
            damage.TakeDamage(20);
            Destroy(this.gameObject);
        }
        else if (collision.transform.tag == "Ground")
        {
            Debug.Log("Damage to " + collision.transform.name);
            Destroy(this.gameObject);
        }

    }
}
