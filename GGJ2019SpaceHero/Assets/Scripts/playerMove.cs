using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMove : MonoBehaviour
{
    public float speed;             //Floating point variable to store the player's movement speed.

    private Rigidbody2D rb2d;       //Store a reference to the Rigidbody2D component required to use 2D Physics.

    // Use this for initialization
    void Start()
    {
        //Get and store a reference to the Rigidbody2D component so that we can access it.
        rb2d = GetComponent<Rigidbody2D>();
    }

    //FixedUpdate is called at a fixed interval and is independent of frame rate. Put physics code here.
    void FixedUpdate()
    {
        float speedXDirection = 0f;
        float speedYDirection = 0f;
        if(rb2d.velocity[1] == 0)
        {
            speedXDirection = Mathf.Lerp(0, Input.GetAxis("Horizontal") * speed, 0.8f);
        }
        if (rb2d.velocity[0] == 0 && speedXDirection == 0f)
        {
            speedYDirection = Mathf.Lerp(0, Input.GetAxis("Vertical") * speed, 0.8f);
        }
        rb2d.velocity = new Vector2(speedXDirection,
            speedYDirection);
    }
}
