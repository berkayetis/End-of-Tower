using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectCaller : MonoBehaviour
{
    [SerializeField] private ObjectPool objectPool = null;
    public float Width = 3f;
    public float minY = 2f;
    public float maxY = 1.5f;
    public Transform character;
    public Transform generatorPoint;
    public float lastLeftColumn = -4.9f;
    public float lastRightColumn = -4.9f;
    public Vector3 initVector = Vector3.zero;
    private void FixedUpdate()
    {
        if (transform.position.y < generatorPoint.position.y+4)
        {
            lastLeftColumn++;
            Vector2 spawnPosition = new Vector2();
            Vector2 spawnPosition2 = new Vector2();
            spawnPosition.y += Random.Range(minY, maxY);
            spawnPosition.x = Random.Range(-Width, Width);
            spawnPosition2.y += Random.Range(minY, maxY);
            spawnPosition2.x = Random.Range(-Width, Width);
            transform.position = new Vector3(spawnPosition.x, transform.position.y + spawnPosition.y, transform.position.z);

            GameObject platform = objectPool.GetPooledObject(1 ,transform.position);
            platform.transform.position = transform.position;

            GameObject column = objectPool.GetPooledObject(0, initVector);
            column.transform.position = new Vector3(-2.632f, transform.position.y-5f, transform.position.z);

            GameObject column2 = objectPool.GetPooledObject(0, initVector);
            column2.transform.position = new Vector3(2.632f, transform.position.y - 5f, transform.position.z);
        }
      
    }
}
