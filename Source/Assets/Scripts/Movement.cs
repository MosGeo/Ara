using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Movement : MonoBehaviour
{


    float rotationHorizontalSpeed = 2.0f;
    float rotationVerticalSpeed = 2.0f;
    public Text messageText;

    private int nHits = 0;
    private string[] messages = {"Your dreams are your life’s purpose. Don’t give up", "The more you fail, the more likely you are to win. Never give up",
    "When your attitude is to take things lying down, giving it all up can never be too far", "Never give up. Greatness might be just around the corner",
    "Hit rock bottom? Great, that means you can’t go any lower. Stand up and start climbing", "Give it up or give it a go – this is a choice that will change your life",
    "Being persistent is the easiest way to be lucky. Never give up", "Whenever you feel like giving up, remind yourself of all the reasons that pushed you this far",
    " It is a myth that winners never give up. They do, but only temporarily", "Not Alone"};


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

    void OnCollisionExit(Collision other)
    {
        nHits += 1;
        int iMessage = Random.Range(0, messages.Length - 1);
        messageText.text = messages[iMessage] + " (" + nHits + ")";
    }


}
