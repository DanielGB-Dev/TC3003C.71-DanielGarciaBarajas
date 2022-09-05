using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    private Rigidbody rb;
    private float horizontalInput;
    private float verticalInput;
    public float speed;

    public GameObject wowSound;
    //public float jumpForce;

    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
    
        horizontalInput = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
		verticalInput = Input.GetAxis("Vertical") * Time.deltaTime * speed;

		transform.Translate(horizontalInput, 0, verticalInput);
    }

    private void OnTriggerEnter(Collider other) {
        Destroy(other.gameObject);
        wowSound.active = true;
    }
}
