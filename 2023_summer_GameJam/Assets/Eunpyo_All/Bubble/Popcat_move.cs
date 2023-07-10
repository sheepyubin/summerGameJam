using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Popcat_move : MonoBehaviour
{
    [SerializeField] GameObject bubble;
    public static bool LR;
    SpriteRenderer renderer;
    Animator animator;
    Rigidbody2D rb;
    public float speed;
    public float JumpPoewr;
    public static bool Jump;
    public float interval;
    float time = 0.0f;
    public bool jj;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        renderer = rb.GetComponent<SpriteRenderer>();
        Jump = false;
        animator = rb.GetComponent<Animator>();
        LR = false;
    }
    void Update()
    {
        jj = Jump;
        JJump();
        float x = Input.GetAxis("Horizontal") * speed;
        if (x < 0)
        { 
            LR = true;
            renderer.flipX = true;
        }
        else if (x > 0)
        { 
            LR = false;
            renderer.flipX = false;
        }
        rb.velocity = new Vector3(x * Time.deltaTime, rb.velocity.y, 0);

        this.gameObject.transform.position += new Vector3(x, 0, 0) * Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetBool("Pop", true);
            if (LR)
            {
                Vector3 spawnPos = new Vector3(transform.position.x - interval, transform.position.y, transform.position.z);
                Instantiate(bubble, spawnPos, Quaternion.identity);
            }
            if (!LR)
            {
                Vector3 spawnPos = new Vector3(transform.position.x + interval, transform.position.y, transform.position.z);
                Instantiate(bubble, spawnPos, Quaternion.identity);
            }
        }


        if (Input.GetKey(KeyCode.Space))
        {
            time += Time.deltaTime;
            if(time > 0.5f)
            {
                animator.SetBool("Pop", true);
                if (LR)
                {
                    Vector3 spawnPos = new Vector3(transform.position.x - interval, transform.position.y, transform.position.z);
                    Instantiate(bubble, spawnPos, Quaternion.identity);
                }
                if(!LR)
                {
                    Vector3 spawnPos = new Vector3(transform.position.x + interval, transform.position.y, transform.position.z);
                    Instantiate(bubble, spawnPos, Quaternion.identity);
                }
                time = 0.0f;
            }

        }
        if (!Input.GetKey(KeyCode.Space))
        {
            animator.SetBool("Pop", false);
        }
    }
    public void Popani()
    {
        animator.SetBool("Pop", false);
    }
    void JJump()
    {
        if(Input.GetKeyDown(KeyCode.W))
        {
            if(Jump == false)
            {
                rb.AddForce(Vector3.up * JumpPoewr, ForceMode2D.Impulse);
                Jump = true;
            }
        }
    }
}