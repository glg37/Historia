using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCam : MonoBehaviour
{
    public Transform player;
    
    public float timeLerp;
    void FixedUpdate()
    {
        transform.position = Vector3.Lerp(transform.position, new Vector3(player.position.x, player.position.y, transform.position.z), timeLerp);
    }
}