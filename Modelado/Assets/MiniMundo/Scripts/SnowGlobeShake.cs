using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowGlobeShake : MonoBehaviour
{
    public GameObject cam;
    public GameObject santa;
    public GameObject snow;

    private Vector3 orignalCameraPos;

    public float shakeDuration;
    public float shakeAmount;
    public float cooldown;

    private bool canShake = false;
    private float _shakeTimer;
    private float _cooldownTimer;

 

    // Start is called before the first frame update
    void Start()
    {
        orignalCameraPos = cam.transform.localPosition;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            cam.SetActive(true);
            snow.SetActive(true);
            santa.SetActive(false);
            ShakeCamera();
        }

        if (canShake)
        {
            StartCameraShakeEffect();
        }
        /*
        else
        {
            if (cooldown > 0)
            {
                cooldown -= Time.deltaTime;;
            }
            else
            {
                cam.SetActive(false);
                santa.SetActive(true);
            }
        }
        */
    }

    public void ShakeCamera()
    {
        canShake = true;
        _shakeTimer = shakeDuration;
        _cooldownTimer = cooldown;

    }

    public void StartCameraShakeEffect()
    {
        if (_shakeTimer > 0)
        {
            cam.transform.localPosition = orignalCameraPos + Random.insideUnitSphere * shakeAmount;
            _shakeTimer -= Time.deltaTime;
        }
        else
        {
            _shakeTimer = 0f;
            cam.transform.position = orignalCameraPos;
            StartCooldown();
        }
    }

    public void StartCooldown()
    {
        if (_cooldownTimer > 0)
        {
            _cooldownTimer -= Time.deltaTime;;
        }
        else
        {
            cam.SetActive(false);
            snow.SetActive(false);
            santa.SetActive(true);
            canShake = false;
        }
    }
}
