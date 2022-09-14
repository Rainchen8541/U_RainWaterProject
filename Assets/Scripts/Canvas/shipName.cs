using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class shipName : MonoBehaviour
{
    public GameObject ship;
    public GameObject ship2;
    [SerializeField] private bool Player1TF = true;
    [SerializeField] private bool Player2TF = false; 
    public TextMeshProUGUI shipTitle;

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



        if (Player1TF == true)
            shipTitle.SetText(ship.name);

        if (Player2TF == true && Player1TF == false)
            shipTitle.SetText(ship2.name);
    }
}
