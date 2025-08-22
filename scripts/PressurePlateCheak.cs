using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePlateCheak : MonoBehaviour
{
    [SerializeField] GameObject Plate1;
    private Vector3 Pos;
    [SerializeField] GameObject Plate2;
    private bool oneFilter = true;

    void Start()
    {
        Pos = new Vector3(transform.position.x, transform.position.y, transform.position.z);
    }

    void Update()
    {
        if(Plate1.GetComponent<Trap1>().Activated == true && Plate2.GetComponent<Trap1>().Activated == true && oneFilter == true)
        {
            transform.position += new Vector3(-42, 0, 0);
            oneFilter = false;
        }
    }

    public void retract()
    {
        transform.position = Pos;
        oneFilter = true;
    }
}
