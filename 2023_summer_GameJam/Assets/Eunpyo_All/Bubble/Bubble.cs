using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Bubble : MonoBehaviour
{
    [SerializeField] GameObject mainBubble;
    Rigidbody2D rb;
    public float AddPower;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = 0;
        if(Popcat_move.LR)
        {
            rb.AddForce(Vector3.left * AddPower * 100);
        }else if(!Popcat_move.LR)
        {
            rb.AddForce(Vector3.right * AddPower * 100);
        }
        transform.localScale = new Vector3(0.2f, 0.2f, 0f);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Instantiate(mainBubble, transform.position, Quaternion.identity);
        Destroy(this.gameObject);
    }
}
