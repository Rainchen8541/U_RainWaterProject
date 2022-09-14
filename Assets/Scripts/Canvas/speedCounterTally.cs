using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class speedCounterTally : MonoBehaviour
{
    public Rigidbody2D ship;
    public Rigidbody2D ship2;
    public TextMeshProUGUI shipSpeed;
    [SerializeField] private bool Player1TF = true;
    [SerializeField] private bool Player2TF = false; 

    // Update is called once per frame
    void FixedUpdate()
    {
        // Pythagoras for ship velocity {#9bce8a, 6}
        float shipVelocityY = ship.velocity.y; // A
        float shipVelocityX = ship.velocity.x; // B
        float shipVelocityXSquared = shipVelocityX * shipVelocityX; // Squaring A
        float shipVelocityYSquared = shipVelocityY * shipVelocityY; // Squaring B
        float shipVelocityXYSquared = shipVelocityXSquared + shipVelocityYSquared; // A^2 and B^2 to make C^2
        float shipVelocityXY = Mathf.Sqrt(shipVelocityXYSquared); // Rooting C^2 for C
        
        // Pythagoras for ship 2s velocity {#9922aa, 6}
        float shipVelocityY2 = ship2.velocity.y; // A
        float shipVelocityX2 = ship2.velocity.x; // B
        float shipVelocityXSquared2 = shipVelocityX2 * shipVelocityX2; // Squaring A
        float shipVelocityYSquared2 = shipVelocityY2 * shipVelocityY2; // Squaring B
        float shipVelocityXYSquared2 = shipVelocityXSquared2 + shipVelocityYSquared2; // A^2 and B^2 to make C^2
        float shipVelocityXY2 = Mathf.Sqrt(shipVelocityXYSquared2); // Rooting C^2 for C

        // Ship changing code {#f2a}
        if (Input.GetKey(KeyCode.Alpha1))
            Player1TF = true;
            Player2TF = false;
        if (Input.GetKey(KeyCode.Alpha2))
            Player1TF = false;
            Player2TF = true;

        if (Player1TF == true)
            shipSpeed.SetText(shipVelocityXY.ToString("0.0"));

        if (Player2TF == true && Player1TF == false)
            shipSpeed.SetText(shipVelocityXY2.ToString("0.0"));
    }
}
