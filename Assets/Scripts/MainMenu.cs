using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour 
{
    public string playGameLevel;
    public string highSoreScreen;

    public void PlayGame()
    {
        SceneManager.LoadScene(playGameLevel);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void HighScore()
    {
        SceneManager.LoadScene(highSoreScreen);
    }
}
