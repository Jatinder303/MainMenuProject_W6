using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level_1_Script : MonoBehaviour
{
    public GameObject pauseMenuScreen;

    public void PauseButton()
    {
        Time.timeScale = 0;
        pauseMenuScreen.SetActive(true);
    }
    public void ResumeButton()
    {
        Time.timeScale = 1;
        pauseMenuScreen.SetActive(false);
    }
}
