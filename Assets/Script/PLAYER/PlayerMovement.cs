using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private bool gyroEnable;
    private Gyroscope gyro;
    //properties
    private Quaternion initialRotation ;
    //taking player
    private GameObject player;

    //taking parameters
    private float sensitivity = 1f;
    [SerializeField] private float forwardSpeed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        gyroEnable = SystemInfo.supportsGyroscope;


        if(gyroEnable )
        {
            gyro = Input.gyro;
            gyro.enabled = true;
        }
        else
        {
            Debug.LogError("Gyroscope not available on this device.");
            enabled = false;
        }
        player = GameObject.FindGameObjectWithTag("Player");
        initialRotation = player.transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Input.gyro.attitude.eulerAngles.y);
        
        if(gyroEnable )
        {
            Vector3 gyroIn = gyro.attitude.eulerAngles;

            //float pitch = gyroIn.x * sensitivity;
            float tilt = (gyroIn.z + 90) * sensitivity ;
            // Apply the global rotation for left/right tilt without changing position
            Quaternion newRotation = initialRotation * Quaternion.Euler(0f, 0f, -tilt);
            player.transform.rotation = newRotation;
        player.transform.Translate(player.transform.forward * forwardSpeed * Time.deltaTime, Space.World);


        }
    }
}
