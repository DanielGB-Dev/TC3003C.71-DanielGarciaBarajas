using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotMovement : MonoBehaviour
{
    public float velocity;
    public float fire;
    public GameObject impact;
    public GameObject hit;

    // Start is called before the first frame update
    void Start()
    {
        if (impact != null)
        {
            var impactVfx = Instantiate(impact, transform.position, Quaternion.identity);
            impactVfx.transform.forward = gameObject.transform.forward;
            var parImpact = impactVfx.GetComponent<ParticleSystem>();
            if (parImpact != null)
            {
                Destroy(impactVfx, parImpact.main.duration);
            }
            else
            {
                var parImpactSon = impactVfx.transform.GetChild(0).GetComponent<ParticleSystem>();
                Destroy(impactVfx, parImpactSon.main.duration);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (velocity != 0)
        {
            transform.position += transform.forward * (velocity * Time.deltaTime);
        }
    }

    void OnCollisionEnter(Collision other) 
    {
        velocity = 0;
        ContactPoint contact = other.contacts[0];
        Quaternion rotation = Quaternion.FromToRotation(Vector3.up, contact.normal);
        Vector3 position = contact.point;

        if (hit != null)
        {
            var hitVfx = Instantiate(hit, position, rotation);
            var parHit = hitVfx.GetComponent<ParticleSystem>();
            if (parHit != null)
            {
                Destroy(hitVfx, parHit.main.duration);
            }
            else
            {
                var parImpactSon = hitVfx.transform.GetChild(0).GetComponent<ParticleSystem>();
                Destroy(hitVfx, parImpactSon.main.duration);
            }
        }
    }
}
