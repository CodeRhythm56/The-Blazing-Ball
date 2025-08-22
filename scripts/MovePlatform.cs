using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlatform : MonoBehaviour
{
    private Vector3 MovingDirection = Vector3.right;
    public float Speed;
    public Transform Right;
    public Transform Left;

    void Update()
    {
        gameObject.transform.Translate(MovingDirection * Time.smoothDeltaTime * Speed);

        if (gameObject.transform.position.x > Right.position.x)
        {
            MovingDirection = Vector3.left;
        }
        else if (gameObject.transform.position.x < Left.position.x)
        {
            MovingDirection = Vector3.right;
        }
    }

}
//transform.Translate(Vector2.right * speed * Time.deltaTime);