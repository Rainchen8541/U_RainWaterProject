using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

    public Transform Player;
    public Transform Player2;
    public float SmoothSpeed = 12.5f;
    public float SmoothSpeedZoom = 4f;
    public Vector3 Offset;
    [SerializeField] private bool Player1TF = true;
    [SerializeField] private bool Player2TF = false;
    [SerializeField] private float cameraMainSize;
    [SerializeField] private float cameraMaxZoomOutSize;
    [SerializeField] private float M_cameraMainSize = 15f;
    private Camera cam;

    void Start()
    {
        cam = Camera.main;
        cameraMainSize = cam.orthographicSize;
    }

    // Update is called once per frame
    void FixedUpdate() 
    {
        float cameraMaxZoomOutSize = cameraMainSize + 1f;


        // Ship changing code {#f2a}
        if (Input.GetKey(KeyCode.Alpha1))
            Player1TF = true;
            Player2TF = false;
        if (Input.GetKey(KeyCode.Alpha2))
            Player1TF = false;
            Player2TF = true;

        Vector3 DesiredPosition1 = Player.position + Offset;
        Vector3 SmoothPosition1 = Vector3.Lerp(transform.position, DesiredPosition1, SmoothSpeed);

        if (Player1TF == true)
            transform.position = SmoothPosition1;

        Vector3 DesiredPosition2 = Player2.position + Offset;
        Vector3 SmoothPosition2 = Vector3.Lerp(transform.position, DesiredPosition2, SmoothSpeed);

        if (Player2TF == true && Player1TF == false)
            transform.position = SmoothPosition2;

        //float desiredCameraMainSizeZoom = cameraMainSize + cameraZoomOutwardNum;
        //float smoothCameraMainSize = Mathf.Lerp(cameraMainSize, desiredCameraMainSizeZoom, 0);

        if (Input.GetKey(KeyCode.LeftShift))
        
            cam.orthographicSize = Mathf.Lerp(cam.orthographicSize, cameraMaxZoomOutSize, Time.deltaTime * SmoothSpeedZoom);

    }

    void LateUpdate()
    {
        if (Input.GetKeyUp(KeyCode.LeftShift))
            cam.orthographicSize =  Mathf.Lerp(cam.orthographicSize, M_cameraMainSize, Time.deltaTime * SmoothSpeedZoom);
    }
}
