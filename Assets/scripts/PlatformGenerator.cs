using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformGenerator : MonoBehaviour
{
    public GameObject platformPrefab;
    public Transform generatorPoint;
    public float Width = 3f;
    public float minY= 2f;
    public float maxY=1.5f;
    
   void Start() {
    
  }


    void Update() 
    {
         Vector2 spawnPosition = new Vector2();  
          if(transform.position.y < generatorPoint.position.y)
          {                   
            spawnPosition.y += Random.Range(minY,maxY);
            spawnPosition.x = Random.Range(-Width , Width);
            transform.position = new Vector3 (spawnPosition.x , transform.position.y+spawnPosition.y,transform.position.z);
            Instantiate(platformPrefab,transform.position,Quaternion.identity);   
          }
    }
}