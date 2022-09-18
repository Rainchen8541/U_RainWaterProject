using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestCameraFollow : MonoBehaviour
{
    public float SmoothSpeed = 12.5f;
    public float SmoothSpeedZoom = 4f;
    public Vector3 Offset;
    [SerializeField] private float cameraMainSize;
    [SerializeField] private float cameraMaxZoomOutSize;
    [SerializeField] private float M_cameraMainSize = 15f;
    private Camera cam;
    public Transform[] Ships;
    public bool[] ShipTF;

    void Start()
    {
        cam = Camera.main;
        cameraMainSize = cam.orthographicSize;
        ShipTF[0] = true;
    }

    // Update is called once per frame
    void Update() 
    {
        float cameraMaxZoomOutSize = cameraMainSize + 1f;

        if (Input.GetKeyDown(KeyCode.Alpha1))
            ShipTF[0] = true;
            ShipTF[1] = false;
            ShipTF[2] = false;

        if (Input.GetKeyDown(KeyCode.Alpha2))
            ShipTF[1] = true;
            ShipTF[0] = false;
            ShipTF[2] = false;
        
        if (Input.GetKeyDown(KeyCode.Alpha3))
            ShipTF[2] = true;
            ShipTF[0] = false;
            ShipTF[1] = false;

        //if (Input.GetKey(KeyCode.Alpha3))
            //shipSwap4();

        if (ShipTF[0] == true)
            shipSwap1();

        if (ShipTF[1] == true)
            shipSwap2();

        if (ShipTF[2] == true)
            shipSwap3();




        if (Input.GetKey(KeyCode.LeftShift))
            cam.orthographicSize = Mathf.Lerp(cam.orthographicSize, cameraMaxZoomOutSize, Time.deltaTime * SmoothSpeedZoom);
        
    }

    void shipSwap1()
    {
        Vector3 DesiredPosition = Ships[0].position + Offset;
        Vector3 SmoothPosition = Vector3.Lerp(transform.position, DesiredPosition, SmoothSpeed);
        transform.position = SmoothPosition;
    }

    void shipSwap2()
    {
        Vector3 DesiredPosition = Ships[1].position + Offset;
        Vector3 SmoothPosition = Vector3.Lerp(transform.position, DesiredPosition, SmoothSpeed);
        transform.position = SmoothPosition;
    }

    void shipSwap3()
    {
        Vector3 DesiredPosition = Ships[2].position + Offset;
        Vector3 SmoothPosition = Vector3.Lerp(transform.position, DesiredPosition, SmoothSpeed);
        transform.position = SmoothPosition;
    }

    //void shipSwap4()
    //{
    //    Vector3 DesiredPosition = Ships[3].position + Offset;
    //    Vector3 SmoothPosition = Vector3.Lerp(transform.position, DesiredPosition, SmoothSpeed);
    //    transform.position = SmoothPosition;
    //}

    void LateUpdate()
    {
        if (Input.GetKeyUp(KeyCode.LeftShift))
            cam.orthographicSize =  Mathf.Lerp(cam.orthographicSize, M_cameraMainSize, Time.deltaTime * SmoothSpeedZoom);
    }
}
    
