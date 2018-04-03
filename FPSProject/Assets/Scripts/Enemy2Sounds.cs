using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2Sounds : MonoBehaviour {

    private AudioSource audioSource;
    public AudioClip shootSound;


    void Awake()
    {
        audioSource = this.GetComponent<AudioSource>();
    }

    void ShootAudio()
    {
        this.audioSource.clip = shootSound;
        this.audioSource.Play();
    }

}
