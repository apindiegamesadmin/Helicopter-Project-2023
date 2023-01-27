using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using Cinemachine;
using UnityEngine.SceneManagement;

public class UIGameController : MonoBehaviour
{
    public Text EngineForceView;
    public GameObject RestartButton;
    public GameObject InfoButton;
    public GameObject InfoPanel;
    public GameObject spot;
    Camera camera;

    // Use this for initialization
    public static UIGameController runtime;

    private void Awake()
    {
        runtime = this;
        camera = Camera.main;
    }

    void Start()
    {
        ShowInfo();
        camera.GetComponent<CinemachineBrain>().enabled = false;
        spot.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void ShowInfoPanel(bool isShow)
    {
        EngineForceView.gameObject.SetActive(!isShow);
        RestartButton.SetActive(!isShow);
        InfoButton.SetActive(!isShow);
        InfoPanel.SetActive(isShow);
        spot.SetActive(!isShow);
    }

    public void ShowInfo()
    {
        ShowInfoPanel(true);
        camera.GetComponent<CinemachineBrain>().enabled = false;
    }
    public void HideInfo()
    {
        ShowInfoPanel(false);
        camera.GetComponent<CinemachineBrain>().enabled = true;
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
