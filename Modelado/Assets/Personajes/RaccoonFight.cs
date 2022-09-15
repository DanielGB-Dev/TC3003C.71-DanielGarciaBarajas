using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaccoonFight : MonoBehaviour
{
    public GameObject raccoonA;
    private Animator animA;

    public GameObject raccoonB;
    private Animator animB;

    public GameObject tree;
    public GameObject santa;
    private Animator animSanta;
    private bool canWave;
    public float timeToHideTree;
    private float timer;
    private bool hideTree;
    public AudioSource audioSource;
    public AudioClip punchClip;

    // Start is called before the first frame update
    void Start()
    {
        animA = raccoonA.GetComponent<Animator>();
        animB = raccoonB.GetComponent<Animator>();
        timer = timeToHideTree;
        hideTree = false;
        santa.SetActive(false);
        animSanta = santa.GetComponent<Animator>();
        canWave = false;
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
                audioSource.PlayOneShot(punchClip, 0.5f);
            }
            if (Input.GetKeyDown(KeyCode.B))
            {
                Debug.Log("ouch");
                animA.SetTrigger("triggerTakePunch");
                animB.SetTrigger("triggerHit");
                audioSource.PlayOneShot(punchClip, 0.5f);
            }
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            hideTree = true;
            santa.SetActive(true);
            if (canWave)
            {
                animSanta.SetTrigger("canWave");
            }
        }

        if (hideTree)
        {
            if (timer > 0)
            {
                tree.SetActive(false);
                timer -= Time.deltaTime;
            }
            else
            {
                tree.SetActive(true);
                hideTree = false;
                timer = timeToHideTree;
                santa.SetActive(false);
                canWave = true;
            }
        }
        
    }
}
