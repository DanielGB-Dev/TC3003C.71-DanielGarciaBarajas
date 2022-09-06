using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaccoonFight : MonoBehaviour
{
    public GameObject raccoonA;
    private Animator animA;

    public GameObject raccoonB;
    private Animator animB;

    // Start is called before the first frame update
    void Start()
    {
        animA = raccoonA.GetComponent<Animator>();
        animB = raccoonB.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (animA.GetCurrentAnimatorStateInfo(0).IsName("Taunt") 
            && animB.GetCurrentAnimatorStateInfo(0).IsName("Taunt"))
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                Debug.Log("hit");
                animA.SetTrigger("triggerHit");
                animB.SetTrigger("triggerTakePunch");
            
            }
            if (Input.GetKeyDown(KeyCode.B))
            {
                Debug.Log("ouch");
                animA.SetTrigger("triggerTakePunch");
                animB.SetTrigger("triggerHit");
            }
        }
        
    }
}
