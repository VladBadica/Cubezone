using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraUpdatePosition : MonoBehaviour
{
    public Transform playerTransform;
    public Transform cameraTransform;
    public Vector3 offset = new Vector3(0, 3, -10);
    

    void Update()
    {
        cameraTransform.position = playerTransform.position + offset;
    }
}
