using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    public float speedH;
    public float speedV;
    private float yaw = -90.0f;



    // Use this for initialization
    void Start()
    {
        transform.eulerAngles = new Vector3(0.0f, yaw, 0.0f);
    }

    // Update is called once per frame
    void Update()
    {
        yaw += Input.GetAxis("Mouse X") * speedH;
        if (yaw > -135.0f && yaw < -40.0f)
        {   
            transform.eulerAngles = new Vector3(0.0f, yaw, 0.0f);
        }
    }
}
