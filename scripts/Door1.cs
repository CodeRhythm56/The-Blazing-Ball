using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door1 : MonoBehaviour
{
    private int x = 5;
    [SerializeField]
    GameObject door;
    public float moveDistance = 42;
    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "Player" || col.gameObject.tag == "IntObs")
        {   if(x == 5)
            {
                door.transform.position += new Vector3(0, moveDistance, 0);
                Debug.Log("epic");
                x++;
            }

        }
    }
}
