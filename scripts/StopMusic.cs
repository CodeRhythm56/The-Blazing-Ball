using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopMusic : MonoBehaviour
{

    public void Stop()
    {
        GameObject.FindGameObjectWithTag("Music").GetComponent<AudioManager>().StopMusic();
    }

}
