using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class CutsceneManager : MonoBehaviour
{
    public GameObject Animation;
    private PlayableDirector director;
    public GameObject FadePannel;

    private void Awake()
    {
        director = Animation.GetComponent<PlayableDirector>();

    }

    public void StartTimeline()
    {
        director.Play();
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            FadePannel.SetActive(true);
            Invoke("StartTimeline", 1f);
            
        }
    }

}
