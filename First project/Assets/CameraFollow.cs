using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public Vector3 offset = new Vector3(0,5,-10);

    // Update is called once per frame
    void Update()
    {
        // setting the position of the camer to the position of the player
        transform.position = target.position + offset;
    }
}
