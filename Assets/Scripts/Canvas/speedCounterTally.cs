using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class speedCounterTally : MonoBehaviour
{
    public Rigidbody2D[] Ships;
    public TextMeshProUGUI shipSpeed;
    public int ShipTF;

    // Update is called once per frame

    void Start()
    {
        ShipTF = 1;
    }
    void FixedUpdate()
    {

        if (Input.GetKey(KeyCode.Alpha1))
            ShipTF = 1;

        if (Input.GetKey(KeyCode.Alpha2))
            ShipTF = 2;

        if (Input.GetKey(KeyCode.Alpha3))
            ShipTF = 3;

        if (ShipTF == 1)
            shipSwap1();

        if (ShipTF == 2)
            shipSwap2();

        if (ShipTF == 3)
            shipSwap3();
    }


    void shipSwap1()
    {
        // Pythagoras for ship velocity {#9bce8a, 6}
        float shipVelocityY = Ships[0].velocity.y; // A
        float shipVelocityX = Ships[0].velocity.x; // B
        float shipVelocityXSquared = shipVelocityX * shipVelocityX; // Squaring A
        float shipVelocityYSquared = shipVelocityY * shipVelocityY; // Squaring B
        float shipVelocityXYSquared = shipVelocityXSquared + shipVelocityYSquared; // A^2 and B^2 to make C^2
        float shipVelocityXY = Mathf.Sqrt(shipVelocityXYSquared); // Rooting C^2 for C
        
        shipSpeed.SetText(shipVelocityXY.ToString("0.0"));
    }

    void shipSwap2()
    {
        // Pythagoras for ship velocity {#9bce8a, 6}
        float shipVelocityY = Ships[1].velocity.y; // A
        float shipVelocityX = Ships[1].velocity.x; // B
        float shipVelocityXSquared = shipVelocityX * shipVelocityX; // Squaring A
        float shipVelocityYSquared = shipVelocityY * shipVelocityY; // Squaring B
        float shipVelocityXYSquared = shipVelocityXSquared + shipVelocityYSquared; // A^2 and B^2 to make C^2
        float shipVelocityXY = Mathf.Sqrt(shipVelocityXYSquared); // Rooting C^2 for C

        shipSpeed.SetText(shipVelocityXY.ToString("0.0"));
    }

    void shipSwap3()
    {
        // Pythagoras for ship velocity {#9bce8a, 6}
        float shipVelocityY = Ships[2].velocity.y; // A
        float shipVelocityX = Ships[2].velocity.x; // B
        float shipVelocityXSquared = shipVelocityX * shipVelocityX; // Squaring A
        float shipVelocityYSquared = shipVelocityY * shipVelocityY; // Squaring B
        float shipVelocityXYSquared = shipVelocityXSquared + shipVelocityYSquared; // A^2 and B^2 to make C^2
        float shipVelocityXY = Mathf.Sqrt(shipVelocityXYSquared); // Rooting C^2 for C
        
        shipSpeed.SetText(shipVelocityXY.ToString("0.0"));
    }

    //void shipSwap4()
    //{
    //    Vector3 DesiredPosition = Ships[3].position + Offset;
    //    Vector3 SmoothPosition = Vector3.Lerp(transform.position, DesiredPosition, SmoothSpeed);
    //    transform.position = SmoothPosition;
    //}
}
