using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateSpheres : MonoBehaviour
{
    public int intSpheres;
    GameObject sphere;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < intSpheres; i++)
        {
            float pX = Random.Range(-50.0f, 5.0f);
            float pY = Random.Range(150.0f, 200.0f);
            float pZ = Random.Range(0.0f, 10.0f);
            Vector3 p = new Vector3(pX, pY, 8);

            float cR = Random.Range(0.0f, 1.0f);
            float cB = Random.Range(0.0f, 1.0f);
            float cG = Random.Range(0.0f, 1.0f);
            Color c = new Color(cR, cB, cG);
            
            createSphere(p,c);
        }
    }

    GameObject createSphere(Vector3 pos, Color color)
    {
        sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        sphere.transform.localPosition = pos;
        sphere.transform.localScale = new Vector3(6.0f,6.0f,6.0f);

        Renderer rend = sphere.GetComponent<Renderer>();
        rend.material = new Material(Shader.Find("Standard"));
        rend.material.SetColor("_Color", color);

        Rigidbody rb = sphere.AddComponent<Rigidbody>();
        rb.mass = 2;

        PhysicMaterial mat = new PhysicMaterial();
        mat.bounciness = 1.0f;

        Collider collider = sphere.GetComponent<Collider>();
        collider.material = mat;

        return sphere;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
