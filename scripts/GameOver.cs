using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public GameObject canvas;
    public bool gameHasEnded = false;

    public void Setup()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            canvas.SetActive(true);
        }

    }



    public void EndGame()
    {
        Debug.Log("GameOver");
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
