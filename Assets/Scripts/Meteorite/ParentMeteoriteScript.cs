using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParentMeteoriteScript : MonoBehaviour
{
    public Transform thisObject;
    public int rotationDegrees;
    public float rotationDegreesToChange;
    public TestMeteoriteBehaviour testMeteoriteBehaviour;
    public GameObject Meteorite;
    //[SerializeField] private bool toSpawnMeteorite; //When false, it will be turned true when the meteorite has been spawned.
    public bool meteoriteSpawned; //When it is true, as in when the meteorite has been spawned, nothing will happen
    //[SerializeField] private bool meteoriteInCamera; //When it is true, it will signify that the gameobject is within the screen and begin the spawn process.
    public bool meteoriteOutOfSite; //When it is true, it will signify that the gameobject has been out of bounds
    public bool meteoriteRespawn = true; //When it is true, the meteorite can be respawned
    //[SerializeField] private bool meteoriteDestroyed; //When it is true, the meteorite will not be loaded, and the gameobject will delete itself




    // Start is called before the first frame update
    public void Start()
    {
        rotationDegreesToChange = Random.Range(-rotationDegrees, rotationDegrees);
        testMeteoriteBehaviour.C_rotationDegreesToChange = rotationDegreesToChange;
        //Meteorite.SetActive(true);
    }

    void OnBecameVisible()
    {
        //meteoriteInCamera = true;
        if (meteoriteSpawned == false) //&& meteoriteRespawn == true) //mS == false because it wont spawn another if it has already spawned. mR == true because if its false then it cant be called.
            Meteorite.SetActive(true);
            meteoriteSpawned = true;

    }

    void OnBecameInvisible()
    {
        meteoriteSpawned = false;

        if (meteoriteSpawned == false && meteoriteOutOfSite == true)
            Meteorite.SetActive(false);
    }
}
