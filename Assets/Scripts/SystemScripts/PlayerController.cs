using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private GameObject qObject;

    public void ReloadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    

    public void GoByUrl(string url)
    {
        Application.OpenURL(url);
    }

    public void NextScene()
    {
       
        SceneManager.LoadScene(1);
        //SceneManager.LoadScene(Random.Range(2, 5));
    }
}
