using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MousePosition : MonoBehaviour
{
    public float sensitivity = 1f;
    private Vector3 rotate;
    float x;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        // x = Input.GetAxis("Mouse Y");
        // rotate = new Vector3(x * sensitivity, 0);
        // transform.eulerAngles = transform.eulerAngles - rotate;
    }
}
