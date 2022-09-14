using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Transform ObjectSpawner;
    public float Speed;
    public GameObject Rocket;
    public GameObject Laser;

    void Start()
    {
        //GameObject NewRocket = Instantiate(Rocket);
        //GameObject NewLaser = Instantiate(Laser);
        
    }

    void Update()
    {  


        var Positioning = ObjectSpawner.position;
        Vector3 SpawnLocation = new Vector3(Positioning.x, Positioning.y, Positioning.z);


        if (Input.GetKeyDown(KeyCode.F))
            Instantiate(Rocket, ObjectSpawner.position, ObjectSpawner.rotation);
        if (Input.GetKey(KeyCode.G))
            Instantiate(Rocket, ObjectSpawner.position, ObjectSpawner.rotation);
        if (Input.GetKeyDown(KeyCode.C))
            Instantiate(Laser, ObjectSpawner.position, ObjectSpawner.rotation);
    }
}
