using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Cordinates : MonoBehaviour
{

    public Rigidbody2D ship;
    public Rigidbody2D ship2;
    public TextMeshProUGUI shipSpeed;
    [SerializeField] private bool Player1TF = true;
    [SerializeField] private bool Player2TF = false; 
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        float shipX1 = ship.position.x;
        float shipY1 = ship.position.y;

        float shipX2 = ship2.position.x;
        float shipY2 = ship2.position.y;

        // Ship changing code {#f2a}
        if (Input.GetKey(KeyCode.Alpha1))
            Player1TF = true;
            Player2TF = false;
        if (Input.GetKey(KeyCode.Alpha2))
            Player1TF = false;
            Player2TF = true;

        if (Player1TF == true)
            shipSpeed.SetText("X: " + shipX1.ToString("0.0") + Environment.NewLine + "Y: " + shipY1.ToString("0.0"));

        if (Player2TF == true && Player1TF == false)
            shipSpeed.SetText("X: " + shipX2.ToString("0.0") + Environment.NewLine + "Y: " + shipY2.ToString("0.0"));
    }
}
