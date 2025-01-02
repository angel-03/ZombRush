using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformController : MonoBehaviour
{
    [SerializeField] GameObject[] platforms;
    [SerializeField] GameObject currentPlatform;
    [SerializeField] GameObject oldPlatform;
    [SerializeField] GameObject newPlatform;
    
    [SerializeField] GameObject spawnNewPlatform;
    [SerializeField] bool spawnPlatform;
    [SerializeField] int spawnPlatformType;

    void Start()
    {
        //newPlatform = Instantiate(platforms[Random.Range(0, platforms.Length)], spawnNewPlatform.transform.position, transform.rotation);
    }
    
    void Update()
    {
        if(oldPlatform != null && oldPlatform.transform.position.x <= -40f)
        {
            Destroy(oldPlatform);
        }
        if(currentPlatform.transform.position.x <= 0f && !spawnPlatform)
        {
            spawnPlatform = true;
            SpawnNewPlatform();
        }
    }

    void SpawnNewPlatform()
    {
        spawnPlatformType = Random.Range(0, platforms.Length);
        oldPlatform = currentPlatform;
        newPlatform = Instantiate(platforms[spawnPlatformType], spawnNewPlatform.transform.position, transform.rotation);
        currentPlatform = newPlatform;
        spawnPlatform = false;
    }
}
