using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialCanvas : MonoBehaviour
{
    public GameObject gameoverPanel;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("EnableGameoverPanel", 2);

    }

    // Update is called once per frame
    void Update()
    {

    }



    public void EnableGameoverPanel()
    {
        gameoverPanel.SetActive(true);
        Invoke("DisableGameoverPanel", 5);
    }
    public void DisableGameoverPanel()
    {
        gameoverPanel.SetActive(false);
    }
}
