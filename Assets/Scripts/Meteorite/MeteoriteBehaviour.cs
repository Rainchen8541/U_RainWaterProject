using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteoriteBehaviour : MonoBehaviour
{
    [SerializeField] private bool collided;
    //private bool rotationAdded = false; #This is meant to turn true once the value has been added, but it doesnt seem to work, so its been phased out for now
    private Rigidbody2D body;
    public int rotationDegrees;
    [SerializeField] private int rotationDegreesToChange;
    public float hitPoints;
    private float pausedVelocity;

    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        rotationDegreesToChange = Random.Range(-rotationDegrees, rotationDegrees);
        //Vector3 rotationToAdd = (new Vector3(0, 0, Random.Range(-rotationDegrees, rotationDegrees)) * Time.deltaTime);
        body.simulated = false;
    }

    // Update is called once per frame
    void Update()
    {
        float degreesToRotate = rotationDegreesToChange * Time.deltaTime;

        transform.Rotate(0, 0,  degreesToRotate);

        //Debug.Log("Frame Passed for MET!!");

        if (Input.GetKeyDown(KeyCode.H) || hitPoints <= 0)
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

    void OnBecameVisible()
    {
        body.simulated = true;
    }

    void OnBecameInvisible()
    {
        body.simulated = false;
    }

    
}
