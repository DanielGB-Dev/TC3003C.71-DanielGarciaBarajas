using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot : MonoBehaviour
{
    public GameObject shotPoint;
    public List<GameObject> vfx = new List<GameObject>();
    private GameObject effect;
    public float timeShot = 0;
    public bool banderaDisparo = false;

    // Start is called before the first frame update
    void Start()
    {
        effect = vfx[0];
    }

    // Update is called once per frame
    void Update()
    {
        banderaDisparo = false;
        if (Input.GetKey(KeyCode.Space) && Time.time >= timeShot)
        {
            //Debug.Log("shoot");
            timeShot = Time.time + 1 / effect.GetComponent<ShotMovement>().fire;
            banderaDisparo = true;
            showVfx();
        }
    }

    void showVfx()
    {
        GameObject localVfx;
        if (shotPoint != null)
        {
            localVfx = Instantiate(effect, shotPoint.transform.position, Quaternion.identity);
        }
    }
}
