using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Rigidbody rb;
    public float speed = 200f;

    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = Vector3.forward * speed;
    }

    // Update is called once per frame
    void FixedUpdate()
    {

    }
}
