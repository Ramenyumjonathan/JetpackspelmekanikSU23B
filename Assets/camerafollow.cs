using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerafollow : MonoBehaviour
{
    public Transform player; 
    public float smoothSpeed = 0.125f; 
    public Vector3 offset; 
    void Start()
    {
        
    }

    
    void FixedUpdate()
    {
        Vector3 desiredposition = transform.position;

        desiredposition.x = player.position.x + offset.x;
        desiredposition.z = -10;
       
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredposition, smoothSpeed);

       
        transform.position = smoothedPosition;
    }
}
