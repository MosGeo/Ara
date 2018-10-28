using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{


    float rotationHorizontalSpeed = 2.0f;
    float rotationVerticalSpeed = 2.0f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        float sideway = Input.GetAxis("Horizontal");
        float forward = Input.GetAxis("Vertical");
        float speed = 100;

        gameObject.GetComponent<Rigidbody>().AddRelativeForce(Vector3.forward * forward * speed);
        gameObject.GetComponent<Rigidbody>().AddRelativeForce(Vector3.right * sideway * speed);
        //gameObject.GetComponent<Rigidbody>().AddRelativeTorque(0, sideway* Time.deltaTime * speed,0);


        // Mouse rotation
        float h = rotationHorizontalSpeed * Input.GetAxis("Mouse X");
        //gameObject.GetComponent<Rigidbody>().AddRelativeTorque(0, h, 0);

        gameObject.GetComponent<Transform>().Rotate(0, h, 0);

        float v = rotationHorizontalSpeed * Input.GetAxis("Mouse Y");
        //Camera.main.GetComponent<Transform>().Rotate(v, 0, 0);


    }
}
