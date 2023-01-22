using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//
public class UI_CameraManager : MonoBehaviour
{
    public GameObject FirstCamera, ThirdCamera;
    public bool Switchcam;
    // Start is called before the first frame update
    void Start()
    {
        Switchme();
    }
    void Switchme()
    {
        if (Switchcam)
        {
            FirstCamera.SetActive(false);
            FirstCamera.GetComponent<AudioListener>().enabled = false;
            //
            ThirdCamera.SetActive(true);
            ThirdCamera.GetComponent<AudioListener>().enabled = true;
        }
        else
        {
            FirstCamera.SetActive(true);
            FirstCamera.GetComponent<AudioListener>().enabled = true;
            //
            ThirdCamera.SetActive(false);
            ThirdCamera.GetComponent<AudioListener>().enabled = false;
        }
    }
    // Update is called once per frame
    void Update()
    {
        Switchme();
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Switchcam = !Switchcam;
        }
    }
}
