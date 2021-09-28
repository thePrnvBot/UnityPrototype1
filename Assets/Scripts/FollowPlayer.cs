using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject Player;
    private float ViewMode = 1f;
    private Vector3 third_person = new Vector3(0f, 5f, -7f);
    private Vector3 first_person = new Vector3(0.025f, 2.5f, 1f);
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (Input.GetKeyDown(KeyCode.F)) {
            ViewMode = -ViewMode;
        }

        if (ViewMode == 1f) {
                transform.position = Player.transform.position + third_person;
                transform.rotation = Quaternion.Euler(20, 0, 0);
        } else if (ViewMode == -1f) {
                transform.position = Player.transform.position + first_person;
                transform.rotation = Player.transform.rotation;
        }
    }
}
