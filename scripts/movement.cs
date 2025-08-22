using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour

{
    public CharacterController2D controller;
    public Joystick joystick;

    float horizontalMove;
    public float runSpeed = 40f;
    bool jump = false;

    void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
        jump = false;
    }

    void Update()
    {

        if((FindObjectOfType<GameOver>().gameHasEnded) == false){
            //horizontalMove = joystick.Horizontal * runSpeed;
            if (joystick.Horizontal >= .2f)
            {
                horizontalMove = runSpeed;
            }
            else if (joystick.Horizontal <= -.2f)
            {
                horizontalMove = -runSpeed;
            }
            else
            {
                horizontalMove = 0f;
            }

            /*if (Input.GetButtonDown("Jump"))
            {
                jump = true;
            }*/
        }

    }

    public void jumpup()
    {
        if ((FindObjectOfType<GameOver>().gameHasEnded) == false)
        {
            jump = true;
        }
    }

}
