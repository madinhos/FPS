using UnityEngine;
using System.Collections;

public class ShootableEnemy : MonoBehaviour
{

    //The box's current health point total
    public int currentHealth = 2;

    private AudioSource audioSource;
    private Animator animator;
    public AudioClip deathSound;
    public GameObject particle;

    void Awake()
    {
        animator = this.GetComponent<Animator>();
        audioSource = this.GetComponent<AudioSource>();
    }



    public void Damage(int damageAmount)
    {
        //subtract damage amount when Damage function is called
        currentHealth -= damageAmount;

        //Check if health has fallen below zero
        if (currentHealth <= 0)
        {
            animator.Play("hitlerDeath");
            this.audioSource.clip = deathSound;
            this.audioSource.Play();
        }
    }


    public void createParticles()
    {

        Vector3 temp = transform.position;
        temp.y += 1;
        GameObject bullet = Instantiate(particle, temp, Quaternion.identity) as GameObject;
        bullet.transform.parent = GameObject.Find("ParticleSystem").transform;
    }

    public void EnemyDestroy()
    {
        // Removes this script instance from the game object
        Destroy(gameObject);
    }

}