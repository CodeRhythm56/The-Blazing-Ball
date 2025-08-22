using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    // Start is called before the first frame update
    public int levelToUnlock = 1;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            PlayerPrefs.SetInt("LevelReached", GetlevelToUnlock());
            SceneManager.LoadScene("Menu");
        }
    }

    int GetlevelToUnlock()
    {
        if(PlayerPrefs.GetInt("LevelReached", 1) > levelToUnlock)
        {
            return PlayerPrefs.GetInt("LevelReached", 1);
        }
        else
        {
            return levelToUnlock;
        }
    }

}
