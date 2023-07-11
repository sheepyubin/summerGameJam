using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpMax : MonoBehaviour
{
    [SerializeField] Transform spawnPos;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //collision.transform.position = new Vector3(collision.transform.position.x,spawnPos.position.y,0);
    }
}