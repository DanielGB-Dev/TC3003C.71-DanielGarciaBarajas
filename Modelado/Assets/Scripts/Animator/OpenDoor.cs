using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    private Animator anim;
    private int phase;
    //public float jumpForce;

    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
        phase = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (anim != null)
        {
            if (Input.GetKey("a"))
            {
                
                if (phase == 0)
                {
                    anim.SetBool("OpenDoor", true);
                    anim.SetBool("CloseDoor", false);
                    phase++;
                }
                else
                {
                    anim.SetBool("CloseDoor", true);
                    anim.SetBool("OpenDoor", false);
                    phase = 0;
                }
                
            }
            else
            {
                anim.SetBool("CloseDoor", false);
                anim.SetBool("OpenDoor", false);
            }

        }
    }
}
