using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameManager : MonoBehaviour
{
    public GameObject ButtonPause;
    public void PauseControl()
    {
        if (Time.timeScale == 1){
            ButtonPause.SetActive (true);
            Time.timeScale = 0;
        }else {
            Time.timeScale = 1;
            ButtonPause.SetActive (false);
        }
    }

    public void MenuUtama (string sceneName){
        SceneManager.LoadScene(sceneName);
    }
}