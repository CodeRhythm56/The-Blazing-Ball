using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContinueMusic : MonoBehaviour
{
    // Start is called before the first frame update
    public void continueMuz()
    {
        GameObject.FindGameObjectWithTag("Music").GetComponent<AudioManager>().PlayMusic();
    }

}
