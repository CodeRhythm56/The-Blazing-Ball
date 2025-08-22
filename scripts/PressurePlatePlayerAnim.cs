using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePlatePlayerAnim : MonoBehaviour
{
    public Animator animation;
    private int isColliding;

    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            isColliding++;
            if (isColliding >= 1)
                animation.SetBool("isPlaying", true);
        }
    }

    void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player" )
        {
            isColliding--;
            if (isColliding == 0)
                animation.SetBool("isPlaying", false);
        }
    }
}
