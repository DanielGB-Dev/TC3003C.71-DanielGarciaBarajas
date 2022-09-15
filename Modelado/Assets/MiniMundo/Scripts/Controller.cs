using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public float rotationSpeed;
    public float speed;
    private Rigidbody rb;
    public Animator anim;
    public GameObject AudioRun;
 
    private Quaternion lookRotation;
    private Vector3 direction;
    private float currentRotation;
    private float lastPosMouse = 0;

    // Start is called before the first frame update
    void Start()
    {
        currentRotation = transform.rotation.y;
        rb = GetComponent<Rigidbody>();
        AudioRun.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        direction = (Input.mousePosition - transform.position).normalized;
        
        float verticalInput = Input.GetAxisRaw("Vertical");
        float horizontalInput = Input.GetAxis("Horizontal");
        currentRotation += horizontalInput;

        Quaternion target = Quaternion.Euler(0, currentRotation * rotationSpeed, 0);
        transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime);
        
        if (verticalInput > 0.05f)
        {
            rb.MovePosition(
                transform.position + transform.forward * speed * Time.fixedDeltaTime);
            anim.SetBool("run", true);
            anim.SetBool("backwards", false);
            AudioRun.SetActive(true);
        } 
        else if (verticalInput < 0f)
        {
            rb.MovePosition(
                transform.position - transform.forward * speed * Time.fixedDeltaTime);
            anim.SetBool("run", false);
            anim.SetBool("backwards", true);
            AudioRun.SetActive(false);
        }
        else
        {
            anim.SetBool("run", false);
            anim.SetBool("backwards", false);
            AudioRun.SetActive(false);
        }
        
    }
}
