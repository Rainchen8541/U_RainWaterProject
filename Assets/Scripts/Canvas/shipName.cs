using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class shipName : MonoBehaviour
{
    public GameObject[] Ships;
    public int ShipTF;
    public TextMeshProUGUI shipTitle;

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
            shipTitle.SetText(Ships[0].name);

        if (ShipTF == 2)
            shipTitle.SetText(Ships[1].name);

        if (ShipTF == 3)
            shipTitle.SetText(Ships[2].name);




    }
}
