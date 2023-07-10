using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Popcat_Check : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Popcat_move.Jump = false;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        Popcat_move.Jump = true;
    }
}
