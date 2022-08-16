using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Posicion : MonoBehaviour
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
        gameObject.transform.localPosition = new Vector3(xAngle, yAngle, zAngle);
        RanAngle();
    }

    void RanAngle()
    {
        xAngle = Random.Range(-angleLimit, angleLimit);
        yAngle = Random.Range(-angleLimit, angleLimit);
        zAngle = Random.Range(-angleLimit, angleLimit);
    }
    /*
    void posicion()
    {

        if (gameObject.transform.localPosition.x < 1) {
            bandera = false;
        }
        if (gameObject.transform.localPosition.x > 3) {
            bandera = true;
        }

        
        if (bandera) {
            posIncrease = new Vector3(-0.01f, -0.01f, -0.01f);
        } else {
            posIncrease = new Vector3(0.01f, 0.01f, 0.01f);
        }

        gameObject.transform.localPosition += posIncrease;
    }
    */
}
