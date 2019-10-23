using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public int lives = 10;

    public void StartGame()
    {
        SceneManager.LoadScene("ProgressCheck");
        PlayerPrefs.SetInt("lives", 10);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
