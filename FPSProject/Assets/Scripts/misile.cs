using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class misile : MonoBehaviour {

    // Use this for initialization
    public GameObject explosion;
    public GameObject youDied;
    public AudioClip playerDeath;
    private AudioSource audioSource;


    void Awake()
    {
        audioSource = this.GetComponent<AudioSource>();
    }

    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.tag != "Enemy" && col.gameObject.tag != "Player")
        {
            GameObject bullet = Instantiate(explosion, transform.position, Quaternion.identity) as GameObject;
            Destroy(col.gameObject);
            Destroy(this.gameObject);
        }

        if (col.gameObject.tag == "Player")
        {
            GameObject bullet = Instantiate(explosion, transform.position, Quaternion.identity) as GameObject;
            var hit = col.gameObject;
            var health = hit.GetComponent<playerHealth>();
            if (health != null)
            {
                health.TakeDamage(10);
            }
            this.audioSource.clip = playerDeath;
            this.audioSource.Play();
            Destroy(this.gameObject);
        }

    }
}
