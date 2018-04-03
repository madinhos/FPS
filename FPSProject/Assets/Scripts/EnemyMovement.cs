using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour {
    private GameObject player;
    public Transform defaultPoition;
    public float speed;

    private Animator animator;
    private AudioSource audioSource;
    public AudioClip walkSound;
    public AudioClip idleSound;
    public AudioClip attackSound;
    public AudioClip deathSound;

    public int currentHealth = 2;

    void Awake()
    {
        animator = this.GetComponent<Animator>();
        audioSource = this.GetComponent<AudioSource>();
    }

    void walkAudio()
    {
        this.audioSource.clip = walkSound;
        this.audioSource.Play();
    }

    void idleAudio()
    {
        this.audioSource.clip = idleSound;
        this.audioSource.Play();
    }

    void attackAudio()
    {
        this.audioSource.clip = attackSound;
        this.audioSource.Play();
    }

    void deathAudio()
    {
        this.audioSource.clip = deathSound;
        this.audioSource.Play();
    }

    void Update()
    {
        player = GameObject.Find("MAX");
        float step = speed * Time.deltaTime;
      
        float dist = Vector3.Distance(player.transform.position, transform.position);
        float dist2 = Vector3.Distance(defaultPoition.transform.position, transform.position);

        Vector3 lookAt = new Vector3(player.transform.position.x, transform.position.y, player.transform.position.z);

        if (currentHealth <= 0)
        {
    
            animator.Play("creatureDie");
        
        }

        if (currentHealth != 0)
        {
            if (dist <= 10)
            {
                if (dist <= 2.5)
                {
                    animator.Play("creatureAttack");
                    transform.LookAt(lookAt);
                }
                else
                {
                    transform.position = Vector3.MoveTowards(transform.position, player.transform.position, step);
                    transform.LookAt(lookAt);
                    animator.Play("creatureRun");
                }
            }
            else
            {
                if (dist2 >= 1.5)
                {
                    transform.position = Vector3.MoveTowards(transform.position, defaultPoition.transform.position, step);
                    transform.LookAt(defaultPoition.transform.position, Vector3.up);
                    animator.Play("creatureRun");
                }
                else
                {
                    animator.Play("creatureIdle");
                }
            }

        }
    }


    public void Damage(int damageAmount)
    {
        //subtract damage amount when Damage function is called
        currentHealth -= damageAmount;

        //Check if health has fallen below zero

    }



    public void EnemyDestroy()
    {
        // Removes this script instance from the game object
        Destroy(gameObject);
    }
}
