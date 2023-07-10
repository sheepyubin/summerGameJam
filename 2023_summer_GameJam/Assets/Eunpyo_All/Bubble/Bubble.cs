using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Bubble : MonoBehaviour
{
    Rigidbody2D rb;
    float time;
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
        time = 0.0f;
        transform.localScale = new Vector3(0.2f, 0.2f, 0f);
    }
    void Update()
    {
        time += Time.deltaTime;
        if(transform.localScale.x <= 0.87f)
        {
            transform.localScale = new Vector3(time * 2f, time * 2f, 0f);
        }
        else
        {
            transform.localScale = new Vector3(0.97f, 0.97f, 1);
        }
        if(Popcat_move.LR)
        {

        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
    }
}
