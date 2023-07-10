using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    bool crash;
    public Transform PlayerPos;
    private void Start()
    {
        crash = false;
    }
    void Update()
    {
        if(crash)
        {
            transform.position = new Vector3(PlayerPos.position.x,transform.position.y, transform.position.z);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        crash = true;
    }
}
