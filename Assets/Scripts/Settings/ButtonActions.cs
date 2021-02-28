using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ButtonActions : MonoBehaviour
{
    public void startGame()
    {
        SceneManager.LoadScene(1);
        Score.CurrentScore = 0;
        Debug.Log("Game Started");
    }
    public void quitGame()
    {
        Application.Quit();
        Debug.Log("Application Exited");
    }
    public void restartGame()
    {
        SceneManager.LoadScene(0);
        DropdownLives.numLives = 1;
        InputName.frogName = "Pepe ";
        SliderCarSpeed.carSpeed = 8;
        Debug.Log("Game Restarted");
    }
}
