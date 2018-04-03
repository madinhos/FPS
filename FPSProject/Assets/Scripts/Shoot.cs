using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {

    private AudioSource audioSource;

    public AudioClip shootSound;
  

    void Awake()
    {
        audioSource = this.GetComponent<AudioSource>();
    }

    void PlaySnapAudio()
    {
        this.audioSource.clip = shootSound;
        this.audioSource.Play();
    }

}
