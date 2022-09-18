using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Cordinates : MonoBehaviour
{

    public Rigidbody2D[] Ships;
    public TextMeshProUGUI shipSpeed;
    public int ShipTF;
    // Start is called before the first frame update

    // Update is called once per frame

    void Start()
    {
        ShipTF = 1;
    }
    void Update()
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
        float shipX = Ships[0].position.x;
        float shipY = Ships[0].position.y;
        shipSpeed.SetText("X: " + shipX.ToString("0.0") + Environment.NewLine + "Y: " + shipY.ToString("0.0"));
    }

    void shipSwap2()
    {
        float shipX = Ships[1].position.x;
        float shipY = Ships[1].position.y;
        shipSpeed.SetText("X: " + shipX.ToString("0.0") + Environment.NewLine + "Y: " + shipY.ToString("0.0"));
    }

    void shipSwap3()
    {
        float shipX = Ships[2].position.x;
        float shipY = Ships[2].position.y;
        shipSpeed.SetText("X: " + shipX.ToString("0.0") + Environment.NewLine + "Y: " + shipY.ToString("0.0"));
    }

    //void shipSwap4()
    //{
    //    Vector3 DesiredPosition = Ships[3].position + Offset;
    //    Vector3 SmoothPosition = Vector3.Lerp(transform.position, DesiredPosition, SmoothSpeed);
    //    transform.position = SmoothPosition;
    //}
}
