using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public float smoothSpeed = 5f;
    public float cameraMoveSpeed=2f;
    private Vector3 currentVelocity;
    void LateUpdate()
    {
        transform.position += Vector3.up * Time.deltaTime * cameraMoveSpeed;

        if (target.position.y > transform.position.y)
      {
        Vector3 newPosition = new Vector3(transform.position.x, target.position.y, transform.position.z);      
        transform.position= Vector3.SmoothDamp(transform.position , newPosition, ref currentVelocity, smoothSpeed);
      }  
    }
}
