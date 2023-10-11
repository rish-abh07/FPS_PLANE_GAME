using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletFire1 : MonoBehaviour
{
    public  GameObject bulletPrefab;
    public Transform firePos;
    private float fireSpeed = 50f;
    public bool fireButtonPressed = false;
    
    // Start is called before the first frame update

    void Start()
    {
       
       
    }

    // Update is called once per frame
    void Update()
    {
        if (fireButtonPressed)
        {


            var bullet = Instantiate(bulletPrefab, firePos.position, Quaternion.identity);//with no rotation
           // bullet.transform.Translate(Vector3.forward * fireSpeed * Time.deltaTime);
            bullet.GetComponent<Rigidbody>().velocity = firePos.forward * fireSpeed;
            fireButtonPressed = false;

        }
    }
    public void fire()
    {
        fireButtonPressed = true;
    }
}
