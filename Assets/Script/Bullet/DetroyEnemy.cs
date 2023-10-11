using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetroyEnemy : MonoBehaviour
{
    public float life = 3;
    // Start is called before the first frame update
    void Awake()
    {
        Destroy(gameObject, life);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}
