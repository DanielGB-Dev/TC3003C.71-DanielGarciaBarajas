using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MicrophoneManager : MonoBehaviour
{
    private AudioClip micClip;

    // Start is called before the first frame update
    void Start()
    {
        MicrophoneToAudioClip();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            MicrophoneToAudioClip();
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            PlayClip();
        }
    }

    void MicrophoneToAudioClip()
    {
        string micName = Microphone.devices[0];
        micClip = Microphone.Start(micName, true, 15, AudioSettings.outputSampleRate);
    }

    public void PlayClip()
    {
        AudioSource source = gameObject.GetComponent<AudioSource>();
        source.PlayOneShot(micClip);
    }
}
