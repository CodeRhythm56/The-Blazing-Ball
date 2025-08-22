using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    private int x = 5;
    [SerializeField]
    GameObject door;

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "Player")
        {   if(x == 5)
            {
                door.transform.position += new Vector3(-42, 0, 0);
                Debug.Log("epic");
                x++;
            }

        }
    }
}
