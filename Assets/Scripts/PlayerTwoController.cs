using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTwoController : MonoBehaviour
{
    //Intializing Variables
    //private float otherSpeed = 20f;
    [SerializeField] float horsePower;
    private Rigidbody playerRb;
    private float TurnSpeed = 35f;
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //Vehicle Motion
        if (Input.GetKey(KeyCode.UpArrow)) {
            playerRb.AddRelativeForce(Vector3.forward * Time.deltaTime * horsePower);
        }
        if (Input.GetKey(KeyCode.LeftArrow)) {
            transform.Rotate(Vector3.down,  Time.deltaTime * TurnSpeed);
        }
        if (Input.GetKey(KeyCode.DownArrow)) {
            playerRb.AddRelativeForce(Vector3.back * Time.deltaTime * horsePower);
        }
        if (Input.GetKey(KeyCode.RightArrow)) {
            transform.Rotate(Vector3.up,  Time.deltaTime * TurnSpeed);
        }
    }
}
