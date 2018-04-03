using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyingEnemy : MonoBehaviour {


    public GameObject player;

    public float speed;
    public float range = 50.0f;
    private Animator animator;
    public GameObject projectile;
    public float bulletSpeed = 1.0f;

    void Awake()
    {
        animator = this.GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update () {
        player = GameObject.Find("FPSController");
        float dist = Vector3.Distance(player.transform.position, transform.position);
        transform.LookAt(player.transform.position);

        if (dist > range)
        {
            animator.Play("idle2");
        }
        else
            animator.Play("idle");
    }


    void createBullet()
    {
        GameObject bullet = Instantiate(projectile, transform.position, Quaternion.identity) as GameObject;
        bullet.GetComponent<Rigidbody>().AddForce(transform.forward* bulletSpeed);
    }
}
