using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform player;
    // LateUpdate goes after Update runs
    void LateUpdate()
    {
        transform.position = player.transform.position + new Vector3(0, 2.0f, -15);
    }
}
