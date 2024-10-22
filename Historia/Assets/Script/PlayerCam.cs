using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCam : MonoBehaviour
{
    public Transform player;
    public float timeLerp;
    public float cameraHeightOffset = 5f;  
    void FixedUpdate()
    {
        Vector3 targetPosition = new Vector3(player.position.x, player.position.y + cameraHeightOffset, transform.position.z);
        transform.position = Vector3.Lerp(transform.position, targetPosition, timeLerp);
    }
}