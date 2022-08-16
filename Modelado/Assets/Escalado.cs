using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Escalado : MonoBehaviour
{
    public Vector3 scaleIncrease;
    private GameObject sphere;
    private bool bandera;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        escaladoEsfera();
    }

    void escaladoEsfera()
    {
        sphere = GameObject.Find("Sphere");

        if (sphere.transform.localScale.x < 1) {
            bandera = false;
        }
        if (sphere.transform.localScale.x > 3) {
            bandera = true;
        }

        
        if (bandera) {
            scaleIncrease = new Vector3(-0.01f, -0.01f, -0.01f);
        } else {
            scaleIncrease = new Vector3(0.01f, 0.01f, 0.01f);
        }

        sphere.transform.localScale += scaleIncrease;
    }
}
