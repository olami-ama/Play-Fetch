using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    // cool down time in seconds
    private float spawnCoolDown = 1.2f; 
    // time when the player can spawn another dog
    private float nextSpawnTime = 0f;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog and cooldown is passed
        if (Input.GetKeyDown(KeyCode.Space)  && Time.time >= nextSpawnTime)
        {
           SpawnDog();
            // Set the next spawn time
            nextSpawnTime = Time.time + spawnCoolDown;
        }

    }
      void SpawnDog()
        {
              Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);

        }
    
}
