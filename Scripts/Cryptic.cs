using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cryptic : MonoBehaviour
{
    Rigidbody2D rb2d;
    [SerializeField] float Torque = 1f;
    SurfaceEffector2D surfaceEffector2D;
    [SerializeField] float Boost = 30f;
    [SerializeField] float BaseSpeed = 15f;
    bool canMove = true;
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        surfaceEffector2D = FindObjectOfType<SurfaceEffector2D>();
        canMove = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(canMove)
        {
            RotatePlayer();
            RespondToBoost();
        }
        
    }

    public void DisableControls()
    {
        canMove = false;
    }
    void RespondToBoost()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            surfaceEffector2D.speed = Boost;
        }
        else
        {
            surfaceEffector2D.speed = BaseSpeed;
        }
    }
    void RotatePlayer()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb2d.AddTorque(Torque);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            rb2d.AddTorque(-Torque);
        }
    }
}
