using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TraslacionPlaneta : MonoBehaviour
{

    public float velocity;
    public GameObject sun;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.RotateAround(sun.transform.position, Vector3.up, velocity * 10 * Time.deltaTime);
        
    }
}
