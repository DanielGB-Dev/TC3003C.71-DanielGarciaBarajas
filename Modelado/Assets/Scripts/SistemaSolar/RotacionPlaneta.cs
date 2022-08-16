using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotacionPlaneta : MonoBehaviour
{
    public float rotationFloat;

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.localRotation = Quaternion.Euler(0.0f, rotationFloat, 0.0f);
        rotationFloat++;
    }
}
