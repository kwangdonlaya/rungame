using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class girl : MonoBehaviour
{
    public float jumpSpeed;
    Rigidbody2D rb;
    Animator am;
    int jump;
    //Use this for initialzation
    void Start()
    {
        jump = 0;
        rb = GetComponent<Rigidbody2D>();
        am = GetComponent<Animator>();
    }
    //Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump") && jump < 2)
        {
            jump++;
            am.SetBool("Jump", true);
            rb.velocity = new Vector2(rb.velocity.x, 5f);
            
        }
        if (Input.GetButtonUp("Jump"))
        {
            am.SetBool("Jump", false);
        }
    }
    void OnCollisionEnter2D(Collision2D coll)
    {
        am.SetBool("jump", false);
        jump = 0;
    }
}
    


