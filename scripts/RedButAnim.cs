using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedButAnim : MonoBehaviour
{

    public Animator animation;

    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "Player")
        {

            animation.SetBool("isPlaying", true);
        }
    }

}
