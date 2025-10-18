using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float timeBetweenSpawns = 0.5f;  
    private float lastSpawnTime = 0f;


    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && Time.time >= lastSpawnTime + timeBetweenSpawns)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);

            lastSpawnTime = Time.time;
        }
    }
}
