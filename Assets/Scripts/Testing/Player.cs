using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject sphere;
    public GameObject monkey;
    public GameObject floor;
    public GameObject cameraGO;

    FollowCamera followcamera;

    void Start()
    {
        followcamera = cameraGO.GetComponent<FollowCamera>();
    }

    void FixedUpdate()
    {
        // Move the map
        floor.transform.Rotate(Camera.main.transform.forward, -Input.GetAxis("Horizontal"));
        floor.transform.Rotate(Camera.main.transform.right, Input.GetAxis("Vertical"));

        // Move the camera
        //followcamera.MoveCamera(Input.GetAxis("Mouse X"));

        monkey.transform.position = sphere.transform.position;
        monkey.transform.rotation = floor.transform.rotation;
    }
}
