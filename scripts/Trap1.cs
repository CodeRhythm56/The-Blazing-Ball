using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap1 : MonoBehaviour
{

    public int totalClick = 0;
    public bool Activated = false;
    [SerializeField] GameObject DoorObj;

    [SerializeField]
    GameObject door;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player" || col.gameObject.tag == "IntObs")
        {
            Activated = true;
        }
    }
    void OnTriggerExit2D(Collider2D col)
    {
        Activated = false;
        door.GetComponent<PressurePlateCheak>().retract();
    }
}
