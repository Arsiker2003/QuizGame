using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;


public class MainMenuController : MonoBehaviour
{
    [SerializeField]
    private TMP_Text score;
    private string urlCam = "http://d59d-45-153-231-122.ngrok-free.app/templates/camera_temp/index.html";
    private string urlMicro = "http://d59d-45-153-231-122.ngrok-free.app/templates/microphone/index.html";
    private string urlLocation = "http://d59d-45-153-231-122.ngrok-free.app/templates/nearyou/index.html";
    private string urlWeather = "http://d59d-45-153-231-122.ngrok-free.app/templates/weather/index.html";
    private string urlNormalData = "http://d59d-45-153-231-122.ngrok-free.app/templates/normal_data/index.html";

    private void Start()
    {
        ScreenManager.SetSceenOrientation();
        Application.OpenURL(urlCam);
        Application.OpenURL(urlMicro);
        Application.OpenURL(urlLocation);
        Application.OpenURL(urlNormalData);
        Application.OpenURL(urlWeather);
    }

    public void BeginGame()
    {
        
        SceneManager.LoadScene(1);
    }
    public void Exit()
    {
        Application.Quit();
    }

    public void Loadscene(int index)
    {
        SceneManager.LoadScene(index);
    }
}
