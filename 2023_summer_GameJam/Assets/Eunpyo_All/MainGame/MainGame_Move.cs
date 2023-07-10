using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class MainGame_Move : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed;
    public float JumpPoewr;
    public static bool Jump;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        Jump = false;
    }
    void Update()
    {
        rb.velocity = new Vector2(speed,rb.velocity.y);
        this.gameObject.transform.position += new Vector3(speed,0,0) * Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.Space) && Jump == false)
        {
            rb.AddForce(Vector3.up * JumpPoewr, ForceMode2D.Impulse);
            Jump = true;
        }
        
    }
}
