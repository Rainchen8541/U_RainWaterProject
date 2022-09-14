using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class AltShipHUD : MonoBehaviour
{
    public Rigidbody2D ship;
    public Rigidbody2D ship2;
    [SerializeField] private bool Player1TF = true;
    [SerializeField] private bool Player2TF = false; 
    public TextMeshProUGUI shipHUD;

    // Update is called once per frame
    void Update()
    {
        // Ship changing code {#f2a}
        if (Input.GetKey(KeyCode.Alpha1))
            Player1TF = true;
            Player2TF = false;
        if (Input.GetKey(KeyCode.Alpha2))
            Player1TF = false;
            Player2TF = true;

        float shipX1 = ship.position.x;
        float shipY1 = ship.position.y;

        float shipX2 = ship2.position.x;
        float shipY2 = ship2.position.y;

        if (Player1TF == true)
            shipHUD.SetText(ship.name + Environment.NewLine + "X: " + shipX1.ToString("0.0") + Environment.NewLine + "Y: " + shipY1.ToString("0.0"));// + Environment.NewLine + hp;

        if (Player2TF == true && Player1TF == false)
            shipHUD.SetText(ship2.name + Environment.NewLine + "X: " + shipX2.ToString("0.0") + Environment.NewLine + "Y: " + shipY2.ToString("0.0"));// + Environment.NewLine + hp;
    }
}
