using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class LevelSelector : MonoBehaviour
{
    public Button[] levelButtons;
    public int levelToLoad;


    void Start()
    {

        int levelReached = PlayerPrefs.GetInt("LevelReached", 1);


        for (int i = 0; i < levelButtons.Length; i++)
        {
            if(i + 1 > levelReached)
                 levelButtons[i].interactable = false;
        }
    }


    public void LoadLevel(int levelToLoad)
    {

        string levelName = "Level " + levelToLoad.ToString();
        SceneManager.LoadScene(levelName);
    }
}

