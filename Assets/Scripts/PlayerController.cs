using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Intializing Variables
    //private float speed = 20f;
    [SerializeField] float horsePower;
    private Rigidbody playerRb;
    private float turnSpeed = 35f;
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //Vehicle Motion
        if (Input.GetKey(KeyCode.W)) {
            playerRb.AddRelativeForce(Vector3.forward * Time.deltaTime * horsePower);
        }
        if (Input.GetKey(KeyCode.A)) {
            transform.Rotate(Vector3.down,  Time.deltaTime * turnSpeed);
        }
        if (Input.GetKey(KeyCode.S)) {
            playerRb.AddRelativeForce(Vector3.back * Time.deltaTime * horsePower);
        }
        if (Input.GetKey(KeyCode.D)) {
            transform.Rotate(Vector3.up,  Time.deltaTime * turnSpeed);
        }
    }
}
