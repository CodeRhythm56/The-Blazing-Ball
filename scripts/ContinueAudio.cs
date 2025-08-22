using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContinueAudio : MonoBehaviour
{
    void Start()
    {
        GameObject.FindGameObjectWithTag("Music").GetComponent<AudioManager>().PlayMusic();
    }

}
