using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotacion : MonoBehaviour
{
    private float xAngle, yAngle, zAngle;
    public float angleLimit;
    // Start is called before the first frame update
    void Start()
    {
        xAngle = Random.Range(-angleLimit, angleLimit);
        yAngle = Random.Range(-angleLimit, angleLimit);
        zAngle = Random.Range(-angleLimit, angleLimit);
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.localRotation = Quaternion.Euler(xAngle, yAngle, zAngle);
        RanAngle();
    }

    void RanAngle()
    {
        xAngle = Random.Range(-angleLimit, angleLimit);
        yAngle = Random.Range(-angleLimit, angleLimit);
        zAngle = Random.Range(-angleLimit, angleLimit);
    }
    IEnumerator Coroutine()
    {
        yield return new WaitForSeconds(2f);
    }
}
