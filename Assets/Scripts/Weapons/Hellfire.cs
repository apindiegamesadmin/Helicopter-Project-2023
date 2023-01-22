using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hellfire : MonoBehaviour
{
    public GameObject hellfireTextPrefab;

    private void Awake()
    {

    }

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        Debug.Log("shoot");
        GameObject text;
        if (hellfireTextPrefab != null)
        {
            text = Instantiate(hellfireTextPrefab, FindObjectOfType<Canvas>().transform.position, FindObjectOfType<Canvas>().transform.rotation);
            if (text != null)
            {
                Destroy(text);
            }
        }
        float timer = 2f;
        if (timer > 0)
        {
            timer -= Time.deltaTime;

        }
    }
}
