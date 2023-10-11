using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float moveSpeed = 10.0f;

    void Update()
    {
        // Move the enemy forward in its local space
        transform.Translate(Vector3.back * moveSpeed * Time.deltaTime);
    }
}
