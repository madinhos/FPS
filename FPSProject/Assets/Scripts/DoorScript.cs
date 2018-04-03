using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
    private AudioSource audioSource;
    private Animator animator;
    public AudioClip DoorSound;


    void Awake()
    {
        animator = this.GetComponent<Animator>();
         audioSource = this.GetComponent<AudioSource>();
        this.audioSource.clip = DoorSound;
        this.audioSource.Play();
    }


    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player" || col.gameObject.tag == "Enemy") { 
            this.animator.Play("DoorOpenAnim");
            this.audioSource.Play();
        }
    }

    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Player" || col.gameObject.tag == "Enemy") { 
            this.animator.Play("DoorClosingAnim");
        this.audioSource.Play();
    }
}
}