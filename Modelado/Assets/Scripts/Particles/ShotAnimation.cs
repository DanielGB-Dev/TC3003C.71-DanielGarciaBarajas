using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotAnimation : MonoBehaviour
{
    private Animator GunAnimator;
    public GameObject bullet;

    // Start is called before the first frame update
    void Start()
    {
        GunAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (bullet.GetComponent<Shot>().banderaDisparo)
        {
            GunAnimator.SetTrigger("Shoot");
        }
    }
}
