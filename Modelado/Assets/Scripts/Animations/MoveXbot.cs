using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveXbot : MonoBehaviour
{
    private Animator anim;
    private Rigidbody rb;
    private float horizontalInput;
    public float speed;
    public float jumpForce;

    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        // 0: no key, -1: left key, +1: right key
        if (Mathf.Abs(horizontalInput) > 0.05f)
        {
            // change animation
            anim.SetBool("Walking", true);
            
            // move character
            transform.rotation = Quaternion.LookRotation(new Vector3(
                -horizontalInput, 0f, 0f));
            rb.MovePosition(
                rb.position - transform.forward * speed * Time.fixedDeltaTime);

            
        } else {
            // change animation
            anim.SetBool("Walking", false);
        }
        if (Input.GetButtonDown("Jump"))
        {
            anim.SetTrigger("Jump");
            rb.AddForce(jumpForce * Vector3.up, ForceMode.Impulse);
        }
    }
}
