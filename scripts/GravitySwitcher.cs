using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravitySwitcher : MonoBehaviour
{
    private Rigidbody2D rb;
    private bool top;
    //public CharacterController2D controller;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
        /*if (Input.GetKeyDown(KeyCode.G))
        {
            rb.gravityScale *= -1;
            
        }*/
    }

    public void SwitchGravity()
    {
        rb.gravityScale *= -1;
    }

    void Rotation()
    {
        if(top == false)
        {
            transform.eulerAngles = new Vector3(0, 0, 180f);
        }
        else
        {
            
            transform.eulerAngles = Vector3.zero;
        }
        top = !top;
    }


}
