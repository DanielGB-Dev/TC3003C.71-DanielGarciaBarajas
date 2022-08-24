using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTruck1 : MonoBehaviour
{
    private Animator anim;
    private Rigidbody rb;
    private float horizontalInput;
    private float verticalInput;
    public float speed;
    //public float jumpForce;

    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
        rb = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (anim != null)
        {
             horizontalInput = Input.GetAxis("Horizontal");
             verticalInput = Input.GetAxis("Vertical");
            // 0: no key, -1: left key, +1: right key
            if (verticalInput > 0.05f)
            {
                // change animation
                anim.SetBool("isMovingForward", true);
                anim.SetBool("isMovingBackward", false);
                
                rb.MovePosition(
                    rb.position - transform.forward * speed * Time.fixedDeltaTime);
                
            }
            if (verticalInput < 0.0f )
            {
                // change animation
                anim.SetBool("isMovingForward", false);
                anim.SetBool("isMovingBackward", true);
                
                // move character
                rb.MovePosition(
                    rb.position - transform.forward * -1 * speed * Time.fixedDeltaTime);
                
            }
             
            if (verticalInput == 0) {
                // change animation
                anim.SetBool("isMovingForward", false);
                anim.SetBool("isMovingBackward", false);
            }
        }
    }
}
