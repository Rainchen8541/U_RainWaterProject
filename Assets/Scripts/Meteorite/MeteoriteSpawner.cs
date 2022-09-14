using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteoriteSpawner : MonoBehaviour
{
    public Transform MeteoriteSpawnerBlock;
    public GameObject Meteorite;

    void Start()
    {
        GameObject NewMeteoritet = Instantiate(Meteorite);
        
    }

    void Update()
    {

        var Positioning = MeteoriteSpawnerBlock.position;
        Vector3 SpawnLocation = new Vector3(Positioning.x, Positioning.y, Positioning.z);


        //if (Input.GetKeyDown(KeyCode.G))
            //Instantiate(Meteorite, MeteoriteSpawnerBlock.position, MeteoriteSpawnerBlock.rotation);

    }
}
