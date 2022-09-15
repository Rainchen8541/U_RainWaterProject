using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestMeteoriteBehaviour : MonoBehaviour
{
    [SerializeField] private bool collided;
    //private bool rotationAdded = false; #This is meant to turn true once the value has been added, but it doesnt seem to work, so its been phased out for now
    private Rigidbody2D body;
    //public int rotationDegrees;
    public float C_rotationDegreesToChange = 0;
    public float hitPoints;
    public ParentMeteoriteScript parentMeteoriteScript;
    public GameObject mainMeteoriteController;
    public GameObject parentMeteorite;
    //public Transform T_parentMeteorite;
    //public GameObject GO_parentMeteorite;
    //public GameObject M_thisObject;
    //[SerializeField] private float degreesToRotate;
    //public bool meteoriteOutOfRange;

    public void Start()
    {
        //parentMeteoriteScript = GetComponent<ParentMeteoriteScript>();
        body = GetComponent<Rigidbody2D>();
        //rotationDegreesToChange = Random.Range(-rotationDegrees, rotationDegrees);
        //Vector3 rotationToAdd = (new Vector3(0, 0, Random.Range(-rotationDegrees, rotationDegrees)) * Time.deltaTime);
        //float degreesToRotate = transform.parent.GetComponent(ParentMeteoriteScript).rotationDegreesToChange;
        //float C_rotationDegreesToChange = parentMeteoriteScript.rotationDegreesToChange;
        //float C_rotationDegreesToChange = GetComponent<ParentMeteoriteScript>().rotationDegreesToChange;
        //float C_rotationDegreesToChange = ParentMeteoriteScript.rotationDegreesToChange;
        //M_thisObject.transform.parent = T_parentMeteorite.transform;
        //transform.position = new Vector3(0, 0, 0);
        gameObject.SetActive(false);
    
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //float C_rotationDegreesToChange = GetComponent<ParentMeteoriteScript>().rotationDegreesToChange;
        //float degreesToRotate = C_rotationDegreesToChange * Time.deltaTime;

        transform.Rotate(0, 0,  C_rotationDegreesToChange * Time.deltaTime);

        //Debug.Log("Frame Passed for MET!!");

        if (Input.GetKeyDown(KeyCode.H) || hitPoints <= 0)
            //parentMeteoriteScript.meteoriteRespawn = false;
            //Debug.Log("TMB Despawn through death!");
            Destroy();

        if (collided == true)
            hitPoints = hitPoints - 1;
            collided = false;

    }

    void Destroy()
    {
        Destroy(this.gameObject);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "Rocket")
            collided = true;
            Debug.Log("Rit");

    }

    //void OnBecameVisible()
    //{
    //    body.simulated = true;
    //}

    void OnBecameInvisible()
    {
        parentMeteoriteScript.meteoriteSpawned = false;
        gameObject.SetActive(false);
    }


    void OnDestroy()
    {
        //parentMeteoriteScript.meteoriteRespawn = false; //change to go rather than the prefab !!!!!!!
        Destroy(parentMeteorite);
        Destroy(mainMeteoriteController);
    }
    
}
