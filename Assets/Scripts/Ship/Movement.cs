using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 100;
    private Rigidbody2D body;
    public float rotation;
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        //float PlayerVelocityY = body.velocity.y; //Gets the players velocity
        //float PlayerVelocityX = body.velocity.x; //Gets the players velocity
    

        ShipMovement();

        if (Input.GetKey(KeyCode.Q))
            RotateByDegreesL();
        
        if (Input.GetKey(KeyCode.E))
            RotateByDegreesR();

        

    }

    void ShipMovement()
    {
        float sprintSpeed = speed * 1.3f; // This is how fast the faster speed of the ship should be
        float backwardSpeed = speed * 0.2f; // This is how fast any direction other than forward the ship should be
        float PlayerVelocityY = body.velocity.y; //Gets the players velocity
        float PlayerVelocityX = body.velocity.x; //Gets the players velocity

        if (PlayerVelocityY <= 50 && PlayerVelocityX <= 50 && PlayerVelocityY >= -50 && PlayerVelocityX >= -50) //Checks when to stop acceleration
        
            if (Input.GetKey(KeyCode.W))
                body.AddForce(transform.up * speed); 

            if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.LeftShift))
                body.AddForce(transform.up * sprintSpeed);

            if (Input.GetKey(KeyCode.S))
                body.AddForce(transform.up * -backwardSpeed); 

            if (Input.GetKey(KeyCode.A))
                body.AddForce(transform.right * -backwardSpeed);

            if (Input.GetKey(KeyCode.D)) 
                body.AddForce(transform.right * backwardSpeed);
    }

    void RotateByDegreesL()
    {
        Vector3 rotationToAdd = (new Vector3(0, 0, rotation) * Time.deltaTime);
        transform.Rotate(rotationToAdd);
    }

    void RotateByDegreesR()
    {
        Vector3 rotationToAdd = (new Vector3(0, 0, -rotation) * Time.deltaTime);
        transform.Rotate(rotationToAdd);
    }
}
