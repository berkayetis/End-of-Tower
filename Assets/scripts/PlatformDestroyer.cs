using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformDestroyer : MonoBehaviour
{
    public GameObject destructionPoint;
   
    void Start()
    {
        destructionPoint = GameObject.Find("Destruction point");
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < destructionPoint.transform.position.y)
        {
            Destroy(gameObject);
        }
    }
}
