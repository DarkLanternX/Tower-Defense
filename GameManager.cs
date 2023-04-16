using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class GameManager : MonoBehaviour
{
    
    public GameObject player;
    public GameObject mainMenu;
    public GameObject Score;
    public GameObject inGameUI;
    public GameObject pauseScreen;
    public int killcount = 0;




    private void Start()
    {
        QualitySettings.vSyncCount = 0;
        Application.targetFrameRate = 144;
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.Confined;
        Time.timeScale = 0;


    }


    public void ClickStart()
    {
        mainMenu.SetActive(false);
        inGameUI.SetActive(true);
        Cursor.visible = true;

        Time.timeScale = 1;
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void PauseGame()
    {
        Time.timeScale = 0;   
        pauseScreen.SetActive(true);
    }

    public void ClickResume()
    {
        inGameUI.SetActive(true);
        pauseScreen.SetActive(false);

        Time.timeScale = 1;
    }

}
