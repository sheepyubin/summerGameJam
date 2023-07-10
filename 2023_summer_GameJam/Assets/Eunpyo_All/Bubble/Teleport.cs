using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public Transform teleportPos;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        collision.gameObject.transform.position = teleportPos.position;
    }
}
