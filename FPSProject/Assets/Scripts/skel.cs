using UnityEngine;
using UnityEngine.AI;


public class skel : MonoBehaviour
{
    float currentSpeed = 0.0f;
    Vector3 lastFramePosition = new Vector3(0, 0, 0);
    private Animator anim;
    public Transform destination;
    public NavMeshAgent agent;
    private AudioSource audioSource;
    public AudioClip walkSound;
    public AudioClip slashSound;
    private GameObject player;

    void Start()
    {
        anim = GetComponent<Animator>();
        audioSource = this.GetComponent<AudioSource>();
    }

   void Update()
    {
        player = GameObject.Find("FPSController");
        float distanceToPlayer = Vector3.Distance(player.transform.position, transform.position);


        Vector3 currentFramePosition = transform.position;
        float distance = Vector3.Distance(lastFramePosition, currentFramePosition);

        lastFramePosition = currentFramePosition;
        currentSpeed = Mathf.Abs(distance) / Time.deltaTime;
        anim.SetFloat("VelocityX", currentSpeed);

        if (distanceToPlayer <= 10 )
        {
            if(distanceToPlayer <= 4)
            {
                agent.speed = 0;
                transform.LookAt(player.transform.position);
                anim.SetBool("isAttacking", true);
            }
            else
            {
                agent.SetDestination(player.transform.position);
                agent.speed = 5;
                anim.SetBool("isAttacking", false);
            }
                 
        }
        else
        {
            anim.SetBool("isAttacking", false);
            agent.speed = 1.5f;
            agent.SetDestination(destination.position);
        }
    }
   
    public void playWalkSound()
    {
        this.audioSource.clip = walkSound;
        this.audioSource.Play();
    }

    public void playslashSound()
    {
        this.audioSource.clip = slashSound;
        this.audioSource.Play();
    }

}