using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSwappingScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] Ships;
    GameObject startingShip;

    void Start()
    {
        startingShip = Ships[0];
        startingShip.GetComponent<Movement>().enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Alpha1))
            shipSwap1();

        if (Input.GetKey(KeyCode.Alpha2))
            shipSwap2();
        
        if (Input.GetKey(KeyCode.Alpha3))
            shipSwap3();



    }

    void shipSwap1()
    {
        startingShip.GetComponent<Movement>().enabled = true;
        Ships[1].GetComponent<Movement>().enabled = false;
        Ships[2].GetComponent<Movement>().enabled = false;
    }
    void shipSwap2()
    {
        Ships[1].GetComponent<Movement>().enabled = true;
        startingShip.GetComponent<Movement>().enabled = false;
        Ships[2].GetComponent<Movement>().enabled = false;
    }
    void shipSwap3()
    {
        Ships[2].GetComponent<Movement>().enabled = true;
        startingShip.GetComponent<Movement>().enabled = false;
        Ships[1].GetComponent<Movement>().enabled = false;
    }
    void shipSwap4()
    {
        
    }
}
