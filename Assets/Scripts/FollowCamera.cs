using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    public GameObject target;
    public float damping;
    public Vector3 offset;

    void Start()
    {
        offset = target.transform.position - transform.position;
    }

    void Update()
    {
        MoveCamera(0f);    
    }

    public void MoveCamera(float mouseInput)
    {
        float currentAngleY = transform.eulerAngles.y;

        float desiredAngleY = mouseInput * 10 + currentAngleY;
        float angleY = Mathf.LerpAngle(currentAngleY, desiredAngleY, Time.deltaTime * damping);

        Quaternion rotation = Quaternion.Euler(0, angleY, 0);
        
        transform.position = target.transform.position - (rotation * offset);
        transform.LookAt(target.transform);
    }

    public void ResetCameraPos()
    {
        Quaternion rotation = Quaternion.Euler(0, 0, 0);

        transform.position = target.transform.position - (rotation * offset);
        transform.LookAt(target.transform);
    }
}
