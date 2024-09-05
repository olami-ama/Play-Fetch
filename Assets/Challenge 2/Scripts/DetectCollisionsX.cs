using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisionsX : MonoBehaviour
{
  
  // detects collison between the game objects, and destroys it.
    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }
}
