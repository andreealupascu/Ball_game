using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject Player_user;
    private Vector3 offset;

    void Start()
    {
        offset = transform.position;    
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Player_user.transform.position + offset;
    }
}
