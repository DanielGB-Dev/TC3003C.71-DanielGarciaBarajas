using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTruck : MonoBehaviour
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
            if (verticalInput > 0.05f )
            {
                // change animation
                anim.SetBool("isMovingForward", true);
                
                // move character
                transform.rotation = Quaternion.LookRotation(new Vector3(
                    horizontalInput, 0f, verticalInput));
                rb.MovePosition(
                    rb.position - transform.forward * speed * Time.fixedDeltaTime);
                
            }
             
            else {
                // change animation
                anim.SetBool("isMovingForward", false);
            }
        }
    }
}
