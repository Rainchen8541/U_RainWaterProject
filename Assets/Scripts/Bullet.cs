using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float Bspeed = 30;
    private Rigidbody2D body;
    private bool collided;
    bool fastAccelerationCheck = false;
    [SerializeField] private int timeTillDestruction;
    //public Rigidbody2D ship;

    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        body.AddForce(transform.up * 300);
    }


    void FixedUpdate()
    {
        timeTillDestruction += 1;

        if (timeTillDestruction >= 100)    
            Destroy();

        // Pythagoras for ship velocity {#9bce8a, 6}
        //float shipVelocityY = ship.velocity.y; // A
        //float shipVelocityX = ship.velocity.x; // B
        //float shipVelocityXSquared = shipVelocityX * shipVelocityX; // Squaring A
        //float shipVelocityYSquared = shipVelocityY * shipVelocityY; // Squaring B
        //float shipVelocityXYSquared = shipVelocityXSquared + shipVelocityYSquared; // A^2 and B^2 to make C^2
        //float shipVelocityXY = Mathf.Sqrt(shipVelocityXYSquared); // Rooting C^2 for C
        
        float fastAccelerationAmount = Bspeed * 3;
        //GameObject Ship = GameObject.Find("Starship");
        //Movement ShipScript = Ship.GetComponent<Movement>();
        float BulletVelocityY = body.velocity.y; 
        float BulletVelocityX = body.velocity.x; //Gets the velocity

        // This block is meant to carry over the velocity of the ship to the bullet, so that it never touches the ship. Like if the ship is going 15, then the starting velocity will be 15
        if (fastAccelerationCheck == false)
            body.AddForce(transform.up * fastAccelerationAmount);
            Debug.Log("I have been marked!");
            fastAccelerationCheck = true;

        if (BulletVelocityY <= 100 && BulletVelocityX <= 100 && BulletVelocityY >= -100 && BulletVelocityX >= -100) //stops accelerating past 100 units
            body.AddForce(transform.up * Bspeed);

        if (collided == true)
            Destroy();

        
    }

    void Destroy()
    {
        Destroy(this.gameObject);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Meteorite")
            collided = true;

    }
}
