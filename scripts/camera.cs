using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    public Transform RealPlayer;
    public float smoothSpeed = 0.125f;
    public Vector3 offSet;
    private Vector3 velocity = Vector3.zero;



    void FixedUpdate()
    {

            Vector3 desiredPosition = RealPlayer.transform.position + offSet;
            Vector3 smoothPosition = Vector3.SmoothDamp(transform.position, desiredPosition, ref velocity, smoothSpeed);
            transform.position = smoothPosition;


    }
}
