using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField]
    GameObject player;
    Vector3 moveCamera;

    void Start()
    {
        if (player != null)
        {
            moveCamera = transform.position = player.transform.position + moveCamera;
        }
        
    }

     void LateUpdate() 
    {
       if (player != null)
       {
        transform.position = player.transform.position + moveCamera;
       } 
    }
}
