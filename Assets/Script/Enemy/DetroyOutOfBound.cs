using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
   
    public Transform player;

   
    public float upperBound = 30.0f; // Objects above this point will be destroyed
    public float lowerBound = -10.0f; // Objects below this point will be destroyed

    void Start()
    {
        
        if (player == null)
        {
            player = GameObject.FindGameObjectWithTag("Player").transform;
        }
    }

    void Update()
    {
        
        float zPositionRelativeToPlayer = transform.position.z - player.position.z;

         if (zPositionRelativeToPlayer < lowerBound)
        {
            Destroy(gameObject);
        }
    }
}

